using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using InkWatch.styling;
using InkWatch.configs;
using InkWatch;



namespace InkWatch.mainForms
{
    public partial class login_Screen : BaseForm
    {
        public string user_name { get; set; }

        
        
        public login_Screen()
        {
            InitializeComponent();
        }
        string connectionadress = $"server={ConfigManager.Settings.ConnectionInfo.ipadress};user=admin;password=admin;database=inkwatchdb;port={ConfigManager.Settings.ConnectionInfo.port}";

       
        private void login_Screen_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Input string'i byte dizisine dönüştür
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Byte dizisini hex (onaltılık) string'e çevir
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // x2: her byte için 2 basamak hexadecimal
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            user_name = textBox1.Text.ToString();
            string plaintext = textBox2.Text.ToString();
            string passwordhash = ComputeSha256Hash(plaintext);
           
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionadress))
                {

                    
                    con.Open();
                    string sql = $"SELECT * FROM tbl_users WHERE username = '{user_name}' AND password_hash = '{passwordhash}'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                           
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!!!", "Yanlış Şifre Veya Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı Hatası: " + ex.Message, "Veritabanı Sorunu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                db_settings db_set = new db_settings();
                pictureBox3.Visible = false;
                db_set.ShowDialog();
                pictureBox3.Visible = true;
                
            }
            catch (Exception ex) { MessageBox.Show("Hata ile karşılaşıldı! " + ex.Message); }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.Focus();
            }
        }
    }
}
