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
}
