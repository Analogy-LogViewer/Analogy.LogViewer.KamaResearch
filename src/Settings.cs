using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.Implementation.KamaResearch
{
    public partial class Settings : Form
    {
        private UserSettingsManager SettingsManager { get; set; }
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            SettingsManager = UserSettingsManager.Instance;
            txtbKafkaAddress.Text = SettingsManager.Settings.KafkaAddress;
            txtbKafkaTopic.Text = SettingsManager.Settings.KafkaTopic;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingsManager.Settings.KafkaAddress = txtbKafkaAddress.Text;
            SettingsManager.Settings.KafkaTopic = txtbKafkaTopic.Text;
            SettingsManager.Save();
        }
    }
}
