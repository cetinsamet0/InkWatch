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

namespace InkWatch
{
    public partial class login_Screen : InkWatch.BaseForm
    {
        public string user_name { get; set; }

        // WinAPI fonksiyonları
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Sürükleme mesaj sabitleri
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        public login_Screen()
        {
            InitializeComponent();
        }
        string connectionadress = $"server={ConfigManager.Settings.ConnectionInfo.ipadress};user=admin;password=admin;database=InkWatch_db;port={ConfigManager.Settings.ConnectionInfo.port}";

        public void checkpass()
        {

            using (MySqlConnection conn = new MySqlConnection(connectionadress))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Bağlantı Başarılı");
                    //string sql = "SELECT * FROM users";
                    //MySqlCommand cmd = new MySqlCommand(sql, conn);
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    MessageBox.Show("Kayıt:" + reader["user_name"] + reader["user_passwd"]);
                    //}
                    //reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void login_Screen_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            user_name = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();
            MessageBox.Show(user_name);
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionadress))
                {

                    
                    con.Open();
                    string sql = $"SELECT * FROM users WHERE user_name = '{user_name}' AND user_passwd = '{password}'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Giriş Başarılı");
                            
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
