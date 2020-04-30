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

namespace Analogy.LogViewer.KamaResearch
{
    public class OfflineLog : IAnalogyOfflineDataProvider
    {
        public string OptionalTitle { get; } = "Kama offline logs";

        public Guid ID { get; } = new Guid("37E87AD9-109E-4E31-A9D7-F0C8D289DC08");

        public bool CanSaveToLogFile { get; } = true;
        public string FileOpenDialogFilters { get; } = "Nlog file (*.nlog)|*.nlog";
        public bool DisableFilePoolingOption { get; } = false;
        public string FileSaveDialogFilters => "NLog file (*.nlog)|*.nlog";
        public IEnumerable<string> SupportFormats { get; } = new[] { "*.nlog" };
        public string InitialFolderFullPath { get; } = @"C:\kalpa\logs";
        public bool UseCustomColors { get; set; } = false;
        public IEnumerable<(string originalHeader, string replacementHeader)> GetReplacementHeaders()
            => Array.Empty<(string, string)>();

        public (Color backgroundColor, Color foregroundColor) GetColorForMessage(IAnalogyLogMessage logMessage)
            => (Color.Empty, Color.Empty);

        public Task InitializeDataProviderAsync(IAnalogyLogger logger)
        {
            LogManager.Instance.SetLogger(logger);
            return Task.CompletedTask;
        }

        public void MessageOpened(AnalogyLogMessage message)
        {
            //nop
        }

        public async Task<IEnumerable<AnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler)
        {
            if (fileName.EndsWith(".nlog", StringComparison.InvariantCultureIgnoreCase))
            {
                LogLoader logLoader = new NlogFileParser();
                return await logLoader.ReadFromFile(fileName, token, messagesHandler).ConfigureAwait(false);

            }
            AnalogyLogMessage m = new AnalogyLogMessage
            {
                Text = $"Unsupported file: {fileName}. Skipping file",
                Level = AnalogyLogLevel.Critical,
                Source = "Analogy",
                Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName,
                ProcessID = System.Diagnostics.Process.GetCurrentProcess().Id,
                Class = AnalogyLogClass.General,
                User = Environment.UserName,
                Date = DateTime.Now
            };
            messagesHandler.AppendMessage(m, Environment.MachineName);
            return new List<AnalogyLogMessage>() { m };
        }


        public IEnumerable<FileInfo> GetSupportedFiles(DirectoryInfo dirInfo, bool recursiveLoad)
        => GetSupportedFilesInternal(dirInfo, recursiveLoad);


        public Task SaveAsync(List<AnalogyLogMessage> messages, string fileName) => Task.Factory.StartNew(() =>
        {
            if (fileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    Utils.Saver.ExportToJson(messages, fileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, @"Error exporting to Json", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            else if (fileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    Utils.Saver.ExportToCSV(messages, fileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, @"Error exporting to Json", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        });

        public bool CanOpenFile(string fileName)

            => fileName.EndsWith(".nlog", StringComparison.InvariantCultureIgnoreCase) ||
               fileName.EndsWith(".json", StringComparison.InvariantCultureIgnoreCase);

        public bool CanOpenAllFiles(IEnumerable<string> fileNames) => fileNames.All(CanOpenFile);


        public static List<FileInfo> GetSupportedFilesInternal(DirectoryInfo dirInfo, bool recursive)
        {
            List<FileInfo> files = dirInfo.GetFiles("*.nlog").Concat(dirInfo.GetFiles("*.json"))
                .ToList();
            if (!recursive)
                return files;
            try
            {
                foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                {
                    files.AddRange(GetSupportedFilesInternal(dir, true));
                }
            }
            catch (Exception)
            {
                return files;
            }

            return files;
        }
    }
}