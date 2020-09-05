using Analogy.Interfaces;
using Analogy.LogViewer.KamaResearch.Managers;
using Analogy.LogViewer.KamaResearch.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Analogy.LogViewer.gRPC.IAnalogy;

namespace Analogy.LogViewer.KamaResearch
{
    public class OnlineLog : gRPCReceiverClient
    {
        public override string OptionalTitle { get; set; } = "Kama gRPC online logs";
        public override Guid Id { get; set; } = new Guid("E37EEA25-6CA3-40B2-8454-D53485887693");
        public override IAnalogyOfflineDataProvider FileOperationsHandler { get; set; } = new OfflineLog();
        public override Image ConnectedLargeImage { get; set; } = Resources.Kama32x32connected;
        public override Image ConnectedSmallImage { get; set; } = Resources.Kama16x16connected;
        public override Image DisconnectedLargeImage { get; set; } = Resources.Kama32x32disconnected;
        public override Image DisconnectedSmallImage { get; set; } = Resources.Kama16x16disconnected;

        private readonly UserSettingsManager settingsManager = UserSettingsManager.Instance;
        //public bool UseCustomColors { get; set; } = false;
        //public IEnumerable<(string originalHeader, string replacementHeader)> GetReplacementHeaders()
        //    => Array.Empty<(string, string)>();

        //public (Color backgroundColor, Color foregroundColor) GetColorForMessage(IAnalogyLogMessage logMessage)
        //    => (Color.Empty, Color.Empty);


        public override Task InitializeDataProviderAsync(IAnalogyLogger logger)
        {
            LogManager.Instance.SetLogger(logger);

            return base.InitializeDataProviderAsync(logger);
        }
    }
}
