﻿#region

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

#endregion

namespace Tabster
{
    public enum ExportFormat
    {
        Tabster,
        Text
    }

    public class TabFile : TabsterFile, ITabsterFile
    {
        public const string FILE_EXTENSION = ".tabster";
        public const string FILE_VERSION = "1.4";

        public TabFile(string filePath, bool autoLoad)
        {
            FileInfo = new FileInfo(filePath);

            if (autoLoad)
                Load();
        }

        public Tab TabData { get; private set; }

        public void Export(ExportFormat format, string filePath)
        {
            switch (format)
            {
                case ExportFormat.Tabster:
                    File.Copy(FileInfo.FullName, filePath);
                    break;
                case ExportFormat.Text:
                    File.WriteAllText(filePath, TabData.Contents);
                    break;
            }
        }

        #region Static Methods

        public static TabFile Create(Tab tab, string directory)
        {
            var filePath = GenerateUniqueFilename(directory, string.Format("{0} - {1} ({2}){3}", tab.Artist, tab.Title, Tab.GetTabString(tab.Type), FILE_EXTENSION));
            var tabFile = new TabFile(filePath, false) {TabData = tab, FileInfo = new FileInfo(filePath)};
            tabFile.Save();
            return tabFile;
        }

        public static bool TryParse(string filePath, out TabFile tabFile)
        {
            var success = false;
            TabFile tf = null;

            try
            {
                tf = new TabFile(filePath, true);
                success = true;
            }

            catch(FileNotFoundException)
            {
                
            }

            catch (IOException)
            {

            }

            catch (XmlException)
            {

            }

            tabFile = tf;
            return success;
        }

        #endregion

        #region Implementation of ITabsterFile

        public void Load()
        {
            Load(true);
        }

        public void Load(bool convertCarriageReturns)
        {
            BeginFileRead(new Version(FILE_VERSION));

            var titleValue = ReadNodeValue("song", true) ?? ReadNodeValue("title");
            var artistValue = ReadNodeValue("artist");
            var typeValue = Tab.GetTabType(ReadNodeValue("type"));
            var contentsValue = ReadNodeValue("tab");
            var createdValue = ReadNodeValue("date", true) ?? ReadNodeValue("created", true);
            var sourceValue = ReadNodeValue("source");
            var sourceType = Tab.GetTabSource(sourceValue);
            var remoteSourceValue = sourceType == TabSource.Download && Uri.IsWellFormedUriString(sourceValue, UriKind.Absolute) ? new Uri(sourceValue) : null;
            var audioValue = ReadNodeValue("audio");
            var lyricsValue = ReadNodeValue("lyrics");

            //fix carriage returns without newlines
            if (convertCarriageReturns)
                contentsValue = new Regex("(?<!\r)\n").Replace(contentsValue, Environment.NewLine);

            TabData = new Tab(artistValue, titleValue, typeValue, contentsValue)
                          {
                              Source = sourceType,
                              RemoteSource = remoteSourceValue,
                              Lyrics = lyricsValue,
                              Audio = audioValue,
                              Created = createdValue != null ? DateTime.Parse(createdValue) : FileInfo.CreationTime
                          };

            if (FileFormatOutdated)
            {
                Save();
                Load();
            }
        }

        public void Save()
        {
            Save(FileInfo.FullName);
        }

        public new void Save(string filePath)
        {
            BeginFileWrite("tabster", FILE_VERSION);
            WriteNode("title", TabData.Title);
            WriteNode("artist", TabData.Artist);
            WriteNode("type", Tab.GetTabString(TabData.Type));
            WriteNode("tab", TabData.Contents);
            WriteNode("created", TabData.Created.ToString());
            WriteNode("comment", TabData.Comment);
            WriteNode("lyrics", TabData.Lyrics);
            WriteNode("audio", TabData.Audio);
            FinishFileWrite();
            FileInfo.Refresh();

            base.Save();
        }

        #endregion
    }
}