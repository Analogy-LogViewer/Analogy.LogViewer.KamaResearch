using Analogy.Interfaces;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Analogy.LogViewer.KamaResearch
{
    public static class NlogDataParser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AnalogyLogMessage ParseData(string data)
        {
            try
            {
                var items = data.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (items.Length == 1)
                {
                    AnalogyLogMessage single = new AnalogyLogMessage(items.First(), AnalogyLogLevel.Error,
                        AnalogyLogClass.General, "N/A");
                    return single;
                }
                AnalogyLogMessage m = new AnalogyLogMessage();
                if (DateTime.TryParse(items[0], out DateTime dt))
                {
                    m.Date = dt;
                }

                switch (items[1])
                {
                    case "OFF":
                        m.Level = AnalogyLogLevel.None;
                        break;
                    case "TRACE":
                        m.Level = AnalogyLogLevel.Trace;
                        break;
                    case "DEBUG":
                        m.Level = AnalogyLogLevel.Debug;
                        break;
                    case "INFO":
                        m.Level = AnalogyLogLevel.Information;
                        break;
                    case "WARN":
                        m.Level = AnalogyLogLevel.Warning;
                        break;
                    case "ERROR":
                        m.Level = AnalogyLogLevel.Error;
                        break;
                    case "FATAL":
                        m.Level = AnalogyLogLevel.Critical;
                        break;
                    default:
                        m.Level = AnalogyLogLevel.Information;
                        break;
                }

                if (items.Length == 2)
                {
                    m.Text = items[0];
                    m.ProcessId = int.Parse(items[1]);
                    m.Level = AnalogyLogLevel.Error;
                    return m;
                }
                m.Source = items[2];
                m.Module = "N/A";//items[];
                if (items.Length > 4)
                {
                    m.ProcessId = int.Parse(items[4]);
                }

                m.Text = items[3];
                return m;
            }
            catch (Exception e)
            {
                string msg = $"Error processing line: {e}";
                return new AnalogyLogMessage(msg, AnalogyLogLevel.Error, AnalogyLogClass.General, "Analogy", "None");
            }

        }
    }
}
