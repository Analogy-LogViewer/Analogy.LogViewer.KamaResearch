using Analogy.Interfaces;
using Analogy.LogViewer.gRPC.IAnalogy;
using Analogy.LogViewer.KamaResearch.Properties;
using System;
using System.Drawing;

namespace Analogy.LogViewer.KamaResearch
{
    public class KamaOnlineLog : gRPCServerClient
    {
        public override string OptionalTitle { get; set; } = "Kama gRPC online logs";
        public override Guid Id { get; set; } = new Guid("E37EEA25-6CA3-40B2-8454-D53485887693");
        public override IAnalogyOfflineDataProvider FileOperationsHandler { get; set; } = new KamaOfflineLog();
        public override Image ConnectedLargeImage { get; set; } = Resources.Kama32x32connected;
        public override Image ConnectedSmallImage { get; set; } = Resources.Kama16x16connected;
        public override Image DisconnectedLargeImage { get; set; } = Resources.Kama32x32disconnected;
        public override Image DisconnectedSmallImage { get; set; } = Resources.Kama16x16disconnected;

    }
}
