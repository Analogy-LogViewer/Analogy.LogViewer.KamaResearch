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
using Analogy.LogViewer.RegexParser.IAnalogy;

namespace Analogy.LogViewer.KamaResearch
{
    public class KamaOfflineLog : RegexOfflineDataProvider
    {
        public override string OptionalTitle { get; set; } = "Kama Regex offline logs";
        public override Guid Id { get; set; } = new Guid("37E87AD9-109E-4E31-A9D7-F0C8D289DC08");
        public override string InitialFolderFullPath { get; } = @"C:\kalpa\logs";
        public override Image LargeImage { get; set; } = Resources.Kama32x32FileOpen;
        public override Image SmallImage { get; set; } = Resources.Kama16x16FileOpen;

        public override Task InitializeDataProviderAsync(IAnalogyLogger logger)
        {
            var regexPattern = new RegexPattern(@"(?<Date>\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}.\d{4})\|(?<Level>\w+)\|(?<Source>.+)\|(?<Text>.*)\|(?<ProcessName>.*)\|(?<ProcessId>.*)",
                "yyyy-MM-dd HH:mm:ss.ffff", "", new List<string> { "*.nlog" });
            if (!RegexParser.Managers.UserSettingsManager.UserSettings.Settings.RegexPatterns.Contains(regexPattern))
                RegexParser.Managers.UserSettingsManager.UserSettings.Settings.RegexPatterns.Insert(0, regexPattern);

            return base.InitializeDataProviderAsync(logger);
        }
    }
}