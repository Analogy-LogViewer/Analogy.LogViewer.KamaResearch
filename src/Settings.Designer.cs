namespace Analogy.LogViewer.KamaResearch
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtbKafkaAddress = new System.Windows.Forms.TextBox();
            this.txtbKafkaTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kafka Address:";
            // 
            // txtbKafkaAddress
            // 
            this.txtbKafkaAddress.Location = new System.Drawing.Point(186, 22);
            this.txtbKafkaAddress.Name = "txtbKafkaAddress";
            this.txtbKafkaAddress.Size = new System.Drawing.Size(200, 30);
            this.txtbKafkaAddress.TabIndex = 1;
            this.txtbKafkaAddress.Text = "localhost:9092";
            // 
            // txtbKafkaTopic
            // 
            this.txtbKafkaTopic.Location = new System.Drawing.Point(186, 58);
            this.txtbKafkaTopic.Name = "txtbKafkaTopic";
            this.txtbKafkaTopic.Size = new System.Drawing.Size(200, 30);
            this.txtbKafkaTopic.TabIndex = 3;
            this.txtbKafkaTopic.Text = "NlogKafka_Logging";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kafka Topic:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 316);
            this.Controls.Add(this.txtbKafkaTopic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbKafkaAddress);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbKafkaAddress;
        private System.Windows.Forms.TextBox txtbKafkaTopic;
        private System.Windows.Forms.Label label2;
    }
}