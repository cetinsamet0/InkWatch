using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using static Org.BouncyCastle.Math.EC.ECCurve;



namespace InkWatch
{
    public partial class app_settingsform : InkWatch.BaseForm
    {
        private System.Windows.Forms.Timer timerSaat;

        public app_settingsform()
        {
            InitializeComponent();
        }

        private void app_settingsform_Load(object sender, EventArgs e)
        {
            configReader();

            

            labelSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            SaatGostericiBaslat();
        }

        private void SaatGostericiBaslat()
        {
            timerSaat = new System.Windows.Forms.Timer();
            timerSaat.Interval = 1000; // 1 saniye
            timerSaat.Tick += (s, e) =>
            {
                labelSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            };
            timerSaat.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        
        private void configReader()
        {
            bool hideApps = ConfigManager.Settings.AppSettings.HideAllApps;
            if (hideApps)
            {
                checkBox1.Checked = true;
            }
            else
            {

                checkBox1.Checked = false;
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string configPath = "appconfig.json";
            string json = File.ReadAllText(configPath); 
            AppConfig config = JsonSerializer.Deserialize<AppConfig>(json);
            config.AppSettings.HideAllApps = checkBox1.Checked;
            var options = new JsonSerializerOptions { WriteIndented = true };
            string updateJson = JsonSerializer.Serialize(config, options);
            File.WriteAllText(configPath, updateJson);


        }
    }
}
