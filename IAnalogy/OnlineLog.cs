using Analogy.Interfaces;
using Analogy.LogViewer.KamaResearch.Managers;
using Analogy.LogViewer.KamaResearch.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Analogy.LogViewer.KamaResearch
{
    //public class OnlineLog : IAnalogyRealTimeDataProvider
    //{
    //    public string OptionalTitle { get; } = "Kama on-line logs";
    //    public Guid ID { get; } = new Guid("E37EEA25-6CA3-40B2-8454-D53485887693");
    //    public bool AutoStartAtLaunch { get; } = true;
    //    public Image OptionalDisconnectedImage { get; } = Resources.Kama;
    //    public Image OptionalConnectedImage { get; } = Resources.Kama;
    //    public bool IsConnected { get; set; }
    //    public IAnalogyOfflineDataProvider FileOperationsHandler { get; } = new OfflineLog();
    //    public event EventHandler<AnalogyDataSourceDisconnectedArgs> OnDisconnected;
    //    public event EventHandler<AnalogyLogMessageArgs> OnMessageReady;
    //    public event EventHandler<AnalogyLogMessagesArgs> OnManyMessagesReady;
    //    private readonly UserSettingsManager settingsManager = UserSettingsManager.Instance;
    //    public bool UseCustomColors { get; set; } = false;
    //    public IEnumerable<(string originalHeader, string replacementHeader)> GetReplacementHeaders()
    //        => Array.Empty<(string, string)>();

    //    public (Color backgroundColor, Color foregroundColor) GetColorForMessage(IAnalogyLogMessage logMessage)
    //        => (Color.Empty, Color.Empty);
    //    private KafkaConsumer<AnalogyLogMessage> Consumer { get; set; }


    //    public Task InitializeDataProviderAsync(IAnalogyLogger logger)
    //    {
    //        LogManager.Instance.SetLogger(logger);
    //        Consumer = new KafkaConsumer<AnalogyLogMessage>(settingsManager.Settings.GroupId + DateTime.Now.Ticks, settingsManager.Settings.KafkaAddress, settingsManager.Settings.KafkaTopic);
    //        Consumer.OnMessageReady += Consumer_OnMessageReady;
    //        Consumer.OnError += Consumer_OnError;
    //        IsConnected = true;

    //        return Task.CompletedTask;
    //    }

    //    public void MessageOpened(AnalogyLogMessage message)
    //    {
    //        //nop
    //    }
    //    private void Consumer_OnError(object sender, KafkaMessageArgs<string> e)
    //    {
    //        AnalogyLogMessage m = new AnalogyLogMessage(e.Message, AnalogyLogLevel.Error, AnalogyLogClass.General, "Analogy");
    //        OnMessageReady?.Invoke(this, new AnalogyLogMessageArgs(m, Environment.MachineName, Environment.MachineName, this.ID));
    //    }

    //    private void Consumer_OnMessageReady(object sender, KafkaMessageArgs<AnalogyLogMessage> e)
    //    {
    //        if (e.Message.Text.Contains("|"))
    //        {
    //            var items = e.Message.Text.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
    //            if (items.Length > 2)
    //            {
    //                e.Message.Text = items[3];
    //            }
    //        }
    //        OnMessageReady?.Invoke(this, new AnalogyLogMessageArgs(e.Message, Environment.MachineName, Environment.MachineName, this.ID));

    //    }

    //    public async Task<bool> CanStartReceiving()
    //    {
    //        await InitializeDataProviderAsync(null);
    //        return await Task.FromResult(Consumer != null);
    //    }

    //    public Task StartReceiving()
    //    {
    //        Consumer.StartConsuming();
    //        return Task.CompletedTask;
    //    }


    //    public Task StopReceiving()
    //    {
    //        Consumer.OnMessageReady -= Consumer_OnMessageReady;
    //        Consumer.StopConsuming(); 
    //        return Task.CompletedTask;
    //    }

    //}
}
