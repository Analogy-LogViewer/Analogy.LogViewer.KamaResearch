using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Analogy.Interfaces;
using Analogy.LogViewer.KamaResearch.Properties;
using Analogy.LogViewer.Template.IAnalogy;

namespace Analogy.LogViewer.KamaResearch.IAnalogy
{
    public class KamaAnalogyImages : AnalogyImages
    {
        public override Image GetLargeOpenFileImage(Guid analogyComponentId) => Resources.Kama32x32FileOpen;
        public override Image GetSmallOpenFileImage(Guid analogyComponentId) => Resources.Kama16x16FileOpen;
        public override Image GetLargeOpenFolderImage(Guid analogyComponentId) => Resources.Kama32x32OpenFolder;

        public override Image GetSmallOpenFolderImage(Guid analogyComponentId) => Resources.Kama16x16OpenFolder;

        public override Image GetLargeRecentFoldersImage(Guid analogyComponentId) => Resources.Kama32x32OpenRecentFolder;

        public override Image GetSmallRecentFoldersImage(Guid analogyComponentId) => Resources.Kama16x16OpenRecentFolder;
        public override Image GetLargeBookmarksImage(Guid analogyComponentId) => Resources.Kama32x32Bookmarks;
        public override Image GetSmallBookmarksImage(Guid analogyComponentId) => Resources.Kama16x16Bookmarks;
        public override Image GetLargeFilePoolingImage(Guid analogyComponentId) => Resources.Kama32x32FilePooling;

        public override Image GetSmallFilePoolingImage(Guid analogyComponentId) => Resources.Kama32x32FilePooling;

        public override Image GetLargeRecentFilesImage(Guid analogyComponentId) => Resources.Kama32x32RecentFiles;

        public override Image GetSmallRecentFilesImage(Guid analogyComponentId) => Resources.Kama16x16RecentFiles;

        public override Image GetLargeKnownLocationsImage(Guid analogyComponentId) => Resources.Kama32x32KnownLocations;

        public override Image GetSmallKnownLocationsImage(Guid analogyComponentId) => Resources.Kama16x16KnownLocations;

        public override Image GetLargeSearchImage(Guid analogyComponentId) => Resources.Kama32x32SearchFiles;

        public override Image GetSmallSearchImage(Guid analogyComponentId) => Resources.Kama16x16SearchFiles;

        public override Image GetLargeCombineLogsImage(Guid analogyComponentId) => Resources.Kama32x32CombineFiles;

        public override Image GetSmallCombineLogsImage(Guid analogyComponentId) => Resources.Kama16x16CombineFiles;

        public override Image GetLargeCompareLogsImage(Guid analogyComponentId) => Resources.Kama32x32CompareFiles;

        public override Image GetSmallCompareLogsImage(Guid analogyComponentId) => Resources.Kama16x16CompareFiles;

        public override Image GetRealTimeConnectedLargeImage(Guid analogyComponentId) => Resources.Kama32x32connected;
        public override Image GetRealTimeConnectedSmallImage(Guid analogyComponentId) => Resources.Kama16x16connected;
        public override Image GetRealTimeDisconnectedLargeImage(Guid analogyComponentId) => Resources.Kama32x32disconnected;
        public override Image GetRealTimeDisconnectedSmallImage(Guid analogyComponentId) => Resources.Kama16x16disconnected;

    }
}
