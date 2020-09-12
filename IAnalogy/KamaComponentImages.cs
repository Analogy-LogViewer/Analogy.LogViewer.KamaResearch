using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Analogy.Interfaces;
using Analogy.LogViewer.KamaResearch.Properties;

namespace Analogy.LogViewer.KamaResearch.IAnalogy
{
    public class KamaComponentImages : IAnalogyComponentImages
    {
        public Image GetLargeImage(Guid analogyComponentId)
        {
            if (analogyComponentId == KamaFactories.Id)
                return Resources.Kama32x32;
            return null;
        }

        public Image GetSmallImage(Guid analogyComponentId)
        {
            if (analogyComponentId == KamaFactories.Id)
                return Resources.Kama16x16;
            return null;
        }

        public Image GetOnlineConnectedLargeImage(Guid analogyComponentId) => Resources.Kama32x32connected;

        public Image GetOnlineConnectedSmallImage(Guid analogyComponentId) => Resources.Kama16x16connected;

        public Image GetOnlineDisconnectedLargeImage(Guid analogyComponentId) => Resources.Kama32x32disconnected;

        public Image GetOnlineDisconnectedSmallImage(Guid analogyComponentId) => Resources.Kama16x16disconnected;

    }

    public class AnalogyImages : IAnalogyImages
    {
        public Image GetLargeOpenFolderImage(Guid analogyComponentId) => Resources.Kama32x32OpenFolder;

        public Image GetSmallOpenFolderImage(Guid analogyComponentId) => Resources.Kama16x16OpenFolder;

        public Image GetLargeRecentFoldersImage(Guid analogyComponentId) => Resources.Kama32x32OpenRecentFolder;

        public Image GetSmallRecentFoldersImage(Guid analogyComponentId) => Resources.Kama16x16OpenRecentFolder;
        public Image GetLargeBookmarksImage(Guid analogyComponentId) => Resources.Kama32x32Bookmarks;
        public Image GetSmallBookmarksImage(Guid analogyComponentId) => Resources.Kama16x16Bookmarks;
        public Image GetLargeFilePoolingImage(Guid analogyComponentId) => Resources.Kama32x32FilePooling;

        public Image GetSmallFilePoolingImage(Guid analogyComponentId) => Resources.Kama32x32FilePooling;

        public Image GetLargeRecentFilesImage(Guid analogyComponentId) => Resources.Kama32x32RecentFiles;

        public Image GetSmallRecentFilesImage(Guid analogyComponentId) => Resources.Kama16x16RecentFiles;

        public Image GetLargeKnownLocationsImage(Guid analogyComponentId) => Resources.Kama32x32KnownLocations;

        public Image GetSmallKnownLocationsImage(Guid analogyComponentId) => Resources.Kama16x16KnownLocations;

        public Image GetLargeSearchImage(Guid analogyComponentId) => Resources.Kama32x32SearchFiles;

        public Image GetSmallSearchImage(Guid analogyComponentId) => Resources.Kama16x16SearchFiles;

        public Image GetLargeCombineLogsImage(Guid analogyComponentId) => Resources.Kama32x32CombineFiles;

        public Image GetSmallCombineLogsImage(Guid analogyComponentId) => Resources.Kama16x16CombineFiles;

        public Image GetLargeCompareLogsImage(Guid analogyComponentId) => Resources.Kama32x32CompareFiles;

        public Image GetSmallCompareLogsImage(Guid analogyComponentId) => Resources.Kama16x16CompareFiles;
    }
}
