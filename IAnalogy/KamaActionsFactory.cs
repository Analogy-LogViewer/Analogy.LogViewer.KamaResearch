using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.LogViewer.KamaResearch.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Analogy.LogViewer.KamaResearch.Managers;

namespace Analogy.LogViewer.KamaResearch.IAnalogy
{
    public class KamaActionsFactory : IAnalogyCustomActionsFactory
    {
        public Guid FactoryId { get; set; } = KamaFactories.Id;
        public string Title { get; set; } = "Kama Research Tools";

        public IEnumerable<IAnalogyCustomAction> Actions { get; } = new List<IAnalogyCustomAction>
        {
            new Action1()
        };

        private class Action1 : IAnalogyCustomAction
        {
            private static string hostingEXE = @"C:\Kalpa\Hosting\Kalpa.Wpf.exe";

            public Action Action { get; } = () =>
            {
                try
                {
                    if (File.Exists(hostingEXE))
                    {
                        Process.Start(hostingEXE);
                    }
                }
                catch (Exception e)
                {
                    LogManager.Instance.LogError(nameof(Action1), $"Error starting {hostingEXE}: {e.Message}");
                }
            };

            public Guid Id { get; set; } = new Guid("43E512C1-D5E0-41F9-858E-23E3E54D5CEE");
            public Image SmallImage { get; set; } = Resources.Kama16x16;
            public Image LargeImage { get; set; } = Resources.Kama32x32;
            public string Title { get; set; } = "Kalpa Hosting";
            public AnalogyCustomActionType Type { get; } = AnalogyCustomActionType.BelongsToProvider;
        }
    }
}