using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;


namespace Analogy.Implementation.KamaResearch
{
    public class KamaFactories : IAnalogyFactory
    {
        public Guid FactoryID { get; } = new Guid("D37EEA25-6CA3-40B2-8454-D53485887693");
        public string Title { get; } = "Kama Research";
        public IAnalogyDataProvidersFactory DataProviders { get; } = new DataSourceFactory();
        public IAnalogyCustomActionsFactory Actions { get; } = new KamaActionsFactory();
        public IEnumerable<IAnalogyChangeLog> ChangeLog => GetChangeLog();
        public IEnumerable<string> Contributors { get; } = new List<string> { "Lior Banai" };
        public string About { get; } = "Kama Research Analogy Implementation";

        private IEnumerable<IAnalogyChangeLog> GetChangeLog()
        {
            yield return new AnalogyChangeLog("Initial version", AnalogChangeLogType.None, "Lior Banai", new DateTime(2019, 09, 01));
        }
    }

    public class DataSourceFactory : IAnalogyDataProvidersFactory
    {
        public string Title { get; } = "Kama Research Logs";
        public IEnumerable<IAnalogyDataProvider> Items { get; } = new List<IAnalogyDataProvider>
            {
                new OnlineLog(),
               //new OfflineLog()
            };
    }
}
