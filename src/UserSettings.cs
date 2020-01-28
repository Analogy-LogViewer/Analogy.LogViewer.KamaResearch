using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Implementation.KamaResearch
{
    [Serializable]
    public class UserSettings
    {
        public string GroupId { get; set; }
        public string KafkaAddress { get; set; }
        public string KafkaTopic { get; set; }
        public UserSettings()
        {
            GroupId = "AnalogyKafka";
            KafkaTopic = "NlogKafka_Logging";
            KafkaAddress = "localhost:9092";
        }
    }
}
