using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Analogy.LogViewer.KamaResearch.Properties;
using Analogy.LogViewer.RegexParser;

namespace Analogy.LogViewer.KamaResearch.IAnalogy
{
    public class KamaUserSettingsFactory : Analogy.LogViewer.RegexParser.IAnalogy.UserSettingsFactory
    {
        public override Guid FactoryId { get; set; } = KamaFactories.Id;
        public override Guid Id { get; set; } = new Guid("006b1f9b-6b27-4c42-ab03-77d0a514fc25");
        public override Image SmallImage { get; set; } = Resources.Kama16x16Settings;
        public override Image LargeImage { get; set; } = Resources.Kama32x32Settings;
        public override string Title { get; set; } = "Kama Settings";

        public KamaUserSettingsFactory()
        {
            RegexSettings nlogRegexSettings = new RegexSettings
            {
                Directory = string.Empty,
                FileOpenDialogFilters = "All Supported formats (*.nlog)|*.nlog|Plain nlog text file (*.nlog)|*.nlog",
                RegexPatterns = new List<RegexPattern>
                {
                   // new RegexPattern(@"(?<Date>\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}.\d{4})\|(?<Level>\w+)\|(?<Source>\w.*)\|(?<Text>.+)","yyyy-MM-dd HH:mm:ss,fff", "", new List<string> {"*.nlog"}),
                    new RegexPattern(@"(?<Date>\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}.\d{4})\|(?<Level>\w+)\|(?<Source>\w.*)\|(?<Text>.+)\|(?<Module>\w+)\|(?<ProcessID>\w.*)", "yyyy-MM-dd HH:mm:ss,fff", "", new List<string> {"*.nlog"})
                }
            };
            Analogy.LogViewer.RegexParser.Managers.UserSettingsManager.UserSettings.Settings = nlogRegexSettings;
        }
    }
}
