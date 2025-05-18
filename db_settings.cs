using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources.Tools;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkWatch
{
    public partial class db_settings : InkWatch.BaseForm
    {
        public db_settings()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Hide();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void db_settings_Load(object sender, EventArgs e)
        {
            try
            {
                string ip = ConfigManager.Settings.ConnectionInfo.ipadress;
                string port = ConfigManager.Settings.ConnectionInfo.port;
                textBox1.Text = ip;
                textBox2.Text = port;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Yeni veritabanı bilgileri kaydedilsin mi? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (soru == DialogResult.Yes)
            {
                string new_ip = textBox1.Text.ToString();
                string new_port = textBox2.Text.ToString();
                ConfigManager.UpdateConnectionInfo(new_ip, new_port);
                MessageBox.Show("Ayarlarınız başarıyla güncellendi!");
            }
            else
            {
                MessageBox.Show("Kaydetme işleminden vazgeçildi!");
            }


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
            }
        }


        private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.Focus();
            }
        }
    }
}
