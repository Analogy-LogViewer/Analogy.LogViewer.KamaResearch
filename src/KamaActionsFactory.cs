using Analogy.Implementation.KamaResearch.Properties;
using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Analogy.Implementation.KamaResearch
{
    public class KamaActionsFactory : IAnalogyCustomActionsFactory
    {
        public Guid FactoryId { get; } = KamaFactories.Id;
        public string Title { get; } = "Kama Unity Implementation";

        public IEnumerable<IAnalogyCustomAction> Actions { get; } = new List<IAnalogyCustomAction>
        {
            new Action1()
        };

        private class Action1 : IAnalogyCustomAction
        {
            public Action Action { get; } = () => { new Settings().ShowDialog(Application.OpenForms[0]); };
            public Guid ID { get; } = new Guid("43E512C1-D5E0-41F9-858E-23E3E54D5CEE");
            public Image Image { get; } = Resources.unity;
            public string Title { get; } = "Open Kama Settings";
        }
    }
}