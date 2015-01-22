﻿#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Tabster.Core.Searching;
using Tabster.Core.Types;
using Tabster.Data;
using Tabster.Data.Processing;

#endregion

namespace Tabster.Forms
{
    internal partial class MainForm
    {
        private readonly List<TablatureSearchResult> _searchResults = new List<TablatureSearchResult>();

        private readonly Dictionary<Uri, TablatureDocument> _searchResultsCache = new Dictionary<Uri, TablatureDocument>();

        private TablatureRating? _activeSearchRating;
        private TablatureType _activeSearchType;
        private List<ITablatureSearchEngine> _searchServices = new List<ITablatureSearchEngine>();
        private List<ITablatureWebImporter> _webImporters = new List<ITablatureWebImporter>();

        private TablatureSearchResult GetSelectedSearchResult()
        {
            var selectedURL = searchDisplay.SelectedRows.Count > 0
                ? new Uri(searchDisplay.SelectedRows[0].Tag.ToString())
                : null;
            return selectedURL != null ? _searchResults.Find(x => x.Source.Equals(selectedURL)) : null;
        }

        private void onlinesearchbtn_Click(object sender, EventArgs e)
        {
            if (listSearchServices.SelectedItems.Count > 0 && (txtSearchArtist.Text.Trim().Length > 0 || txtSearchTitle.Text.Trim().Length > 0))
            {
                onlinesearchbtn.Enabled = false;

                searchPreviewEditor.Clear();

                //ignore "all tabs"
                _activeSearchType = searchTypeList.HasTypeSelected ? searchTypeList.SelectedType : null;

                _activeSearchRating = null;

                if (cbSearchRating.SelectedIndex > 0)
                    _activeSearchRating = (TablatureRating) (cbSearchRating.SelectedIndex);

                var queries = BuildSearchQueries();

                if (queries.Count > 0)
                {
                    SearchBackgroundWorker.RunWorkerAsync(queries);
                }
            }
        }

        private List<TablatureSearchQuery> BuildSearchQueries()
        {
            var searchArtist = txtSearchArtist.Text.Trim();
            var searchTitle = txtSearchTitle.Text.Trim();

            var searchQueries = new List<TablatureSearchQuery>();

            for (var i = 0; i < listSearchServices.Items.Count; i++)
            {
                if (listSearchServices.GetSelected(i))
                {
                    var service = _searchServices[i];

                    //check engine requirements
                    if ((service.RequiresArtistParameter && string.IsNullOrEmpty(searchArtist)) ||
                        (service.RequiresTitleParameter && string.IsNullOrEmpty(searchTitle)) ||
                        (service.RequiresTypeParamter && _activeSearchType == null ||
                         (_activeSearchRating.HasValue && !service.SupportsRatings)))
                        continue;

                    searchQueries.Add(new TablatureSearchQuery(service, searchArtist, searchTitle, _activeSearchType));
                }
            }

            return searchQueries;
        }

        private void SearchBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var totalResults = new List<TablatureSearchResult>();

            var count = 0;

            var queries = (List<TablatureSearchQuery>) e.Argument;

            var proxy = Program.CustomProxyController.GetProxy();

            foreach (var query in queries)
            {
                try
                {
                    if (query.Type == null || query.Engine.SupportsTabType(query.Type))
                    {
                        var results = query.Engine.Search(query, proxy);

                        if (results != null)
                        {
                            totalResults.AddRange(results);
                        }
                    }
                }

                catch
                {
                    //unhandled
                }

                count++;

                SearchBackgroundWorker.ReportProgress(count);
            }

            e.Result = totalResults;
        }

        private void SearchBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            searchDisplay.SuspendLayout();
            searchDisplay.Rows.Clear();
            _searchResults.Clear();

            onlinesearchbtn.Enabled = true;

            if (e.Result != null)
            {
                var results = (List<TablatureSearchResult>) e.Result;

                _searchResults.AddRange(results);

                foreach (var result in results)
                {
                    DisplaySearchResult(result);
                }
            }

            searchDisplay.ResumeLayout();

            lblStatus.Text = string.Format("Search Results: {0}", searchDisplay.Rows.Count);
        }

        private void SearchBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var serviceName = _searchServices[e.ProgressPercentage - 1].Name;
            if (serviceName != null)
                lblStatus.Text = string.Format("Searching: {0}", serviceName);
        }

        private void DisplaySearchResult(TablatureSearchResult result)
        {
            //missing source url
            if (result.Source == null)
                return;

            //subpar rating
            if (_activeSearchRating.HasValue && (result.Rating <= _activeSearchRating.Value))
                return;

            //tab type mismatch
            if (_activeSearchType != null && result.Tab.Type != _activeSearchType)
                return;

            var newRow = new DataGridViewRow {Tag = result.Source.ToString()};

            var ratingString = result.Rating == TablatureRating.None
                ? ""
                : new string('\u2605', (int) result.Rating - 1).PadRight(5, '\u2606');

            newRow.CreateCells(searchDisplay, result.Tab.Artist, result.Tab.Title, result.Tab.Type.ToFriendlyString(), ratingString, result.Query.Engine.Name);
            searchDisplay.Rows.Add(newRow);
        }

        private void dataGridViewExtended1_MouseClick(object sender, MouseEventArgs e)
        {
            var currentMouseOverRow = searchDisplay.HitTest(e.X, e.Y).RowIndex;

            if (e.Button == MouseButtons.Right && (currentMouseOverRow >= 0 && currentMouseOverRow < searchDisplay.Rows.Count))
            {
                searchDisplay.Rows[currentMouseOverRow].Selected = true;
                SearchMenu.Show(searchDisplay.PointToScreen(e.Location));
            }
        }

        private void dataGridViewExtended1_SelectionChanged(object sender, EventArgs e)
        {
            LoadGetSelectedSearchResultPreview();

            var selectedResult = GetSelectedSearchResult();
            saveTabToolStripMenuItem1.Enabled = selectedResult != null && _searchResultsCache.ContainsKey(selectedResult.Source);
        }

        private void SaveGetSelectedSearchResult()
        {
            var selectedResult = GetSelectedSearchResult();

            if (selectedResult != null)
            {
                using (var nt = new NewTabDialog(selectedResult.Tab.Artist, selectedResult.Tab.Title, selectedResult.Tab.Type))
                {
                    if (nt.ShowDialog() == DialogResult.OK)
                    {
                        var cachedTab = _searchResultsCache[selectedResult.Source];

                        var libraryItem = Program.TablatureFileLibrary.Add(cachedTab);
                        Program.TablatureFileLibrary.Save();
                        UpdateLibraryItem(libraryItem);
                    }
                }
            }
        }

        private void CopyGetSelectedSearchResultUrl()
        {
            var result = GetSelectedSearchResult();

            if (result != null)
            {
                Clipboard.SetDataObject(result.Source.ToString());
            }
        }

        private void LoadGetSelectedSearchResultPreview()
        {
            var selectedResult = GetSelectedSearchResult();

            if (selectedResult != null)
            {
                if (SearchPreviewBackgroundWorker.IsBusy)
                    SearchPreviewBackgroundWorker.CancelAsync();

                searchPreviewEditor.Text = "Loading Preview...";

                if (!SearchPreviewBackgroundWorker.IsBusy)
                    SearchPreviewBackgroundWorker.RunWorkerAsync(selectedResult.Source);
            }
        }

        private void SearchPreviewBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var url = (Uri) e.Argument;

            e.Result = url;

            var result = _searchResults.Find(x => x.Source == url);

            if (!_searchResultsCache.ContainsKey(url))
            {
                var parser = _webImporters.Find(x => x.IsUrlParsable(result.Source));

                if (parser == null)
                {
                    throw new TablatureProcessorException(string.Format("No parser found for URL: {0}", url));
                }

                var proxy = Program.CustomProxyController.GetProxy();

                TablatureDocument tab;

                try
                {
                    tab = parser.Parse(result.Source, proxy);
                }

                catch (Exception ex)
                {
                    throw new TablatureProcessorException(ex.Message);
                }

                if (tab != null)
                {
                    tab.Source = result.Source;
                    tab.SourceType = TablatureSourceType.Download;
                    _searchResultsCache[result.Source] = tab;
                }
            }
        }

        private void SearchPreviewBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                searchPreviewEditor.Text = string.Format("Tab preview failed:{0}{0}{1}", Environment.NewLine, e.Error.Message);
            }

            if (!e.Cancelled && e.Error == null)
            {
                var url = (Uri) e.Result;

                if (_searchResultsCache.ContainsKey(url))
                {
                    var tab = _searchResultsCache[url];
                    searchPreviewEditor.LoadTablature(tab);

                    if (!searchhiddenpreviewToolStripMenuItem.Checked && searchSplitContainer.Panel2Collapsed)
                    {
                        searchSplitContainer.Panel2Collapsed = false;
                        previewToolStrip.Enabled =
                            previewToolStripMenuItem.Enabled = searchSplitContainer.Panel2Collapsed;
                    }

                    //enable save tab option
                    var selectedResult = GetSelectedSearchResult();

                    if (selectedResult != null && selectedResult.Source == url)
                    {
                        saveTabToolStripMenuItem1.Enabled = true;
                    }
                }
            }
        }

        /// <summary>
        ///     Removes version convention from tablature titles.
        /// </summary>
        private static string RemoveVersionConventionFromTitle(string title)
        {
            var versionConventionIndex = title.IndexOf(" (ver ", StringComparison.OrdinalIgnoreCase);

            if (versionConventionIndex >= 0)
                title = title.Remove(versionConventionIndex);

            return title;
        }

        private void BuildSearchSuggestions()
        {
            var artistStrings = new List<string>();
            var titleStrings = new List<string>();

            foreach (var item in Program.TablatureFileLibrary)
            {
                if (artistStrings.Find(x => x.Equals(item.Document.Artist, StringComparison.OrdinalIgnoreCase)) == null)
                    artistStrings.Add(item.Document.Artist);

                var title = RemoveVersionConventionFromTitle(item.Document.Title);
                if (titleStrings.Find(x => x.Equals(title, StringComparison.OrdinalIgnoreCase)) == null)
                    titleStrings.Add(title);
            }

            var artistSuggestions = new AutoCompleteStringCollection();
            var titleSuggestions = new AutoCompleteStringCollection();

            foreach (var str in artistStrings)
                artistSuggestions.Add(str);

            foreach (var str in titleStrings)
                titleSuggestions.Add(str);

            txtSearchArtist.AutoCompleteCustomSource = artistSuggestions;
            txtSearchTitle.AutoCompleteCustomSource = titleSuggestions;
        }

        private void InitializeSearchControls(bool resetUserFields = false)
        {
            if (resetUserFields)
            {
                txtSearchArtist.Text = "";
                txtSearchTitle.Text = "";

                searchTypeList.SelectDefault();
                cbSearchRating.SelectedIndex = 0;
            }

            listSearchServices.Items.Clear();

            for (var i = 0; i < _searchServices.Count; i++)
            {
                var service = _searchServices[i];
                listSearchServices.Items.Add(service.Name);
                listSearchServices.SetSelected(i, true);
            }
        }

        private void resetSearchbtn_Click(object sender, EventArgs e)
        {
            InitializeSearchControls(true);
        }

        private void searchDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                SaveGetSelectedSearchResult();
        }

        private void copyURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyGetSelectedSearchResultUrl();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchSplitContainer.Panel2Collapsed)
                TogglePreviewPane(sender, e);

            LoadGetSelectedSearchResultPreview();
        }
    }
}