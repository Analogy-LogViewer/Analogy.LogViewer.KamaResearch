using Analogy.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Analogy.Interfaces.DataTypes;

namespace Analogy.LogViewer.KamaResearch
{
    public abstract class LogLoader
    {
        public abstract Task<IEnumerable<AnalogyLogMessage>> ReadFromStream(Stream dataStream, CancellationToken token, ILogMessageCreatedHandler messagesHandler);

        public virtual async Task<IEnumerable<AnalogyLogMessage>> ReadFromFile(string filename, CancellationToken token, ILogMessageCreatedHandler logWindow)
        {

            if (!File.Exists(filename))
            {
                await Task.CompletedTask;
                return new List<AnalogyLogMessage>();
            }

            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                return await ReadFromStream(fs, token, logWindow);
            }
        }
    }

    class NlogFileParser : LogLoader
    {
        protected string FileName;

        public override async Task<IEnumerable<AnalogyLogMessage>> ReadFromFile(string filename, CancellationToken token, ILogMessageCreatedHandler logWindow)
        {


            FileName = filename;
            return await base.ReadFromFile(filename, token, logWindow);

        }
        public override async Task<IEnumerable<AnalogyLogMessage>> ReadFromStream(Stream dataStream, CancellationToken token, ILogMessageCreatedHandler messagesHandler)
        {

            List<AnalogyLogMessage> messages = new List<AnalogyLogMessage>();
            try
            {
                long count = 0;
                using (StreamReader streamReader = new StreamReader(dataStream, Encoding.UTF8))
                {

                    while (!streamReader.EndOfStream)
                    {
                        string line = await streamReader.ReadLineAsync();
                        var m = NlogDataParser.ParseData(line);
                        messages.Add(m);
                        count++;
                        messagesHandler.ReportFileReadProgress(new AnalogyFileReadProgress(AnalogyFileReadProgressType.Incremental, 1, count, count));
                        if (token.IsCancellationRequested)
                        {
                            string msg = "Processing canceled by User.";
                            messages.Add(new AnalogyLogMessage(msg, AnalogyLogLevel.Information, AnalogyLogClass.General, "Analogy", "None"));
                            messagesHandler.AppendMessages(messages, Utils.GetFileNameAsDataSource(FileName));
                            return messages;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                string msg = $"Error processing line: {e}";
                messages.Add(new AnalogyLogMessage(msg, AnalogyLogLevel.Error, AnalogyLogClass.General, "Analogy", "None"));
            }
            if (!messages.Any())
            {
                AnalogyLogMessage empty = new AnalogyLogMessage($"File {FileName} is empty or corrupted", AnalogyLogLevel.Error, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = Process.GetCurrentProcess().ProcessName
                };
                messages.Add(empty);

            }
            messagesHandler.AppendMessages(messages, Utils.GetFileNameAsDataSource(FileName));
            return messages;
        }


    }
}