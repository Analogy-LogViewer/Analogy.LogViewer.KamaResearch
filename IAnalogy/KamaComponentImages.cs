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

        public Image GetLargeFilePoolingImage(Guid analogyComponentId) => null;

        public Image GetSmallFilePoolingImage(Guid analogyComponentId) => null;

        public Image GetLargeRecentFilesImage(Guid analogyComponentId) => null;

        public Image GetSmallRecentFilesImage(Guid analogyComponentId) => null;

        public Image GetLargeKnownLocationsImage(Guid analogyComponentId) => null;

        public Image GetSmallKnownLocationsImage(Guid analogyComponentId) => null;

        public Image GetLargeSearchImage(Guid analogyComponentId) => null;

        public Image GetSmallSearchImage(Guid analogyComponentId) => null;

        public Image GetLargeCombineLogsImage(Guid analogyComponentId) => null;

        public Image GetSmallCombineLogsImage(Guid analogyComponentId) => null;

        public Image GetLargeCompareLogsImage(Guid analogyComponentId) => null;

        public Image GetSmallCompareLogsImage(Guid analogyComponentId) => null;
    }
}
