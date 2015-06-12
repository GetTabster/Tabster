﻿#region

using Tabster.Data.Binary;
using Tabster.Data.Processing;
using Tabster.Data.Xml;

#endregion

namespace Tabster.Data
{
    public static class TabsterXmlFileConverter
    {

#pragma warning disable 612
        private static readonly TabsterFileProcessor<TablatureDocument> TablatureDocumentProcessor;
        private static readonly TabsterFileProcessor<TablaturePlaylistDocument> TablaturePlaylistDocumentProcessor;
#pragma warning restore 612

        static TabsterXmlFileConverter()
        {
#pragma warning disable 612
            TablatureDocumentProcessor = new TabsterFileProcessor<TablatureDocument>(TablatureDocument.FileVersion);
            TablaturePlaylistDocumentProcessor = new TabsterFileProcessor<TablaturePlaylistDocument>(TablaturePlaylistDocument.FileVersion);
#pragma warning restore 612
        }

        public static TablatureFile ConvertTablatureDocument(string fileName)
        {
            var doc = TablatureDocumentProcessor.Load(fileName);

            if (doc != null)
            {
                var file = new TablatureFile
                {
                    Artist = doc.Artist,
                    Title = doc.Title,
                    Type = doc.Type,
                    Contents = doc.Contents,
                    SourceType = doc.SourceType,
                    Source = doc.Source,
                    Comment = doc.Comment,
                    Lyrics = doc.Lyrics,
                    FileAttributes = doc.FileAttributes,
                };

                //xml format uses ISO-8859-1, binary uses UTF-8 by default
                file.FileAttributes.Encoding = TablatureFile.DefaultEncoding;

                return file;
            }

            return null;
        }

        public static TablaturePlaylistFile ConvertTablaturePlaylist(string fileName)
        {
            var doc = TablaturePlaylistDocumentProcessor.Load(fileName);

            if (doc != null)
            {
                var file = new TablaturePlaylistFile
                {
                    Name = doc.Name,
                    FileAttributes = doc.FileAttributes,
                };

                foreach (var item in doc)
                {
                    file.Add(item);
                }

                return file;
            }

            return null;
        }
    }
}