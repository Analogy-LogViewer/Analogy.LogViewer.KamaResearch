using Analogy.Interfaces;
using Analogy.LogViewer.KamaResearch.Properties;
using Analogy.LogViewer.RegexParser;
using Analogy.LogViewer.RegexParser.IAnalogy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Analogy.LogViewer.KamaResearch
{
    public class KamaOfflineLog : RegexOfflineDataProvider
    {
        public override string OptionalTitle { get; set; } = "Kama Regex offline logs";
        public override Guid Id { get; set; } = new Guid("37E87AD9-109E-4E31-A9D7-F0C8D289DC08");
        public override string? InitialFolderFullPath { get; set; } = @"C:\kalpa\logs";
        public override Image LargeImage { get; set; } = Resources.Kama32x32FileOpen;
        public override Image SmallImage { get; set; } = Resources.Kama16x16FileOpen;

        public override Task InitializeDataProvider(IAnalogyLogger logger)
        {
            var regexPattern = new RegexPattern(@"(?<Date>\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}.\d{4})\|(?<Level>\w+)\|(?<Source>.+)\|(?<Text>.*)\|(?<ProcessName>.*)\|(?<ProcessId>.*)",
                "yyyy-MM-dd HH:mm:ss.ffff", "", new List<string> { "*.nlog" });
            if (!RegexParser.Managers.UserSettingsManager.UserSettings.Settings.RegexPatterns.Contains(regexPattern))
            {
                RegexParser.Managers.UserSettingsManager.UserSettings.Settings.RegexPatterns.Insert(0, regexPattern);
            }


            var regexPatternPython = new RegexPattern(@"(?<Date>\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}.\d{6})\s(?<Source>\w+)\:\s(?<Text>.*)",
                "yyyy-MM-dd HH:mm:ss.ffffff", "", new List<string> { "*.txt" });
            if (!RegexParser.Managers.UserSettingsManager.UserSettings.Settings.RegexPatterns.Contains(regexPatternPython))
            {
                RegexParser.Managers.UserSettingsManager.UserSettings.Settings.RegexPatterns.Insert(1, regexPatternPython);
            }
            var regexPatternPython2 = new RegexPattern(@"(?<Date>\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}.\d{6})\s\[(?<Level>\w+)\]\s\[(?<Source>\w+)\]\s(?<Text>.*)",
                "yyyy-MM-dd HH:mm:ss.ffffff", "", new List<string> { "*.txt" });
            if (!RegexParser.Managers.UserSettingsManager.UserSettings.Settings.RegexPatterns.Contains(regexPatternPython2))
            {
                RegexParser.Managers.UserSettingsManager.UserSettings.Settings.RegexPatterns.Insert(1, regexPatternPython2);
            }
            return base.InitializeDataProvider(logger);
        }
    }
}