using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.KamaResearch.IAnalogy
{
    public class KamaFactories : IAnalogyFactory
    {
        internal static Guid Id = new Guid("D37EEA25-6CA3-40B2-8454-D53485887693");
        public Guid FactoryId { get; set; } = Id;
        public string Title { get; set; } = "Kama Research";
        public IEnumerable<IAnalogyChangeLog> ChangeLog { get; set; } = GetChangeLog();
        public IEnumerable<string> Contributors { get; set; } = new List<string> { "Lior Banai" };
        public string About { get; set; } = "Kama Research Analogy Implementation";

        private static IEnumerable<IAnalogyChangeLog> GetChangeLog()
        {
            yield return new AnalogyChangeLog("Initial version", AnalogChangeLogType.None, "Lior Banai", new DateTime(2019, 09, 01));
        }
    }

    public class DataSourceFactory : IAnalogyDataProvidersFactory
    {
        public Guid FactoryId { get; set; } = KamaFactories.Id;
        public string Title { get; set; } = "Kama Research Logs";

        public IEnumerable<IAnalogyDataProvider> DataProviders { get; } = new List<IAnalogyDataProvider>
            {
               new OnlineLog(),
               new OfflineLog()
            };
    }
}
