using Analogy.Interfaces;
using Analogy.LogViewer.KamaResearch.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.LogViewer.KamaResearch.Properties;
using Analogy.LogViewer.RegexParser;

namespace Analogy.LogViewer.KamaResearch
{
    public class OfflineLog : Analogy.LogViewer.RegexParser.IAnalogy.OfflineDataProvider
    {
        public override string OptionalTitle { get; set; } = "Kama Regex offline logs";

        public override Guid Id { get; set; } = new Guid("37E87AD9-109E-4E31-A9D7-F0C8D289DC08");

        public override string InitialFolderFullPath { get; } = @"C:\kalpa\logs";
        public override Image LargeImage { get; set; } = Resources.Kama32x32FileOpen;
        public override Image SmallImage { get; set; } = Resources.Kama16x16FileOpen;


        public override Task InitializeDataProviderAsync(IAnalogyLogger logger)
        {
            RegexSettings nlogRegexSettings = new RegexSettings()
            {
                Directory = string.Empty,
                FileOpenDialogFilters = "All Supported formats (*.nlog)|*.nlog|Plain nlog text file (*.nlog)|*.nlog",
                RegexPatterns = new List<RegexPattern>
                {
                    new RegexPattern(
                        @"\$(?<Date>\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2},\d{3})+\|+(?<Thread>\d+)+\|(?<Level>\w+)+\|+(?<Source>.*)\|(?<Text>.*)",
                        "yyyy-MM-dd HH:mm:ss,fff", "", new List<string> {"*.nlog"})
                }
            };
            Analogy.LogViewer.RegexParser.Managers.UserSettingsManager.UserSettings.Settings = nlogRegexSettings;
            LogManager.Instance.SetLogger(logger);
            return base.InitializeDataProviderAsync(logger);

        }
    }
}