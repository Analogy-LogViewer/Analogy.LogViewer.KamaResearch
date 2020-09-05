using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Analogy.LogViewer.KamaResearch.Properties;

namespace Analogy.LogViewer.KamaResearch.IAnalogy
{
    public class KamaUserSettingsFactory : Analogy.LogViewer.RegexParser.IAnalogy.UserSettingsFactory
    {
        public override Guid FactoryId { get; set; } = KamaFactories.Id;
        public override Guid Id { get; set; } = new Guid("006b1f9b-6b27-4c42-ab03-77d0a514fc25");
        public override Image SmallImage { get; set; } = Resources.Kama16x16Settings;
        public override Image LargeImage { get; set; } = Resources.Kama32x32Settings;
        public override string Title { get; set; } = "Kama Settings";
    }
}
