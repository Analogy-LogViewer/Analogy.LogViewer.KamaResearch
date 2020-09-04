using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.LogViewer.KamaResearch.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Analogy.LogViewer.KamaResearch.IAnalogy
{
    public class KamaActionsFactory : IAnalogyCustomActionsFactory
    {
        public Guid FactoryId { get; set; } = KamaFactories.Id;
        public string Title { get; set; } = "Kama Unity Implementation";

        public IEnumerable<IAnalogyCustomAction> Actions { get; } = new List<IAnalogyCustomAction>
        {
            new Action1()
        };

        private class Action1 : IAnalogyCustomAction
        {
            public Action Action { get; } = () => { new Settings().ShowDialog(Application.OpenForms[0]); };
            public Guid Id { get; set; } = new Guid("43E512C1-D5E0-41F9-858E-23E3E54D5CEE");
            public Image SmallImage { get; set; } = Resources.Kama;
            public Image LargeImage { get; set; } = Resources.Kama;
            public string Title { get; set; } = "Open Kama Settings";
            public AnalogyCustomActionType Type { get; } = AnalogyCustomActionType.BelongsToProvider;
        }
    }
}