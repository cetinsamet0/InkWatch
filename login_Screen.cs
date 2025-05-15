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

namespace InkWatch
{
    public partial class login_Screen : Form
    {
        public login_Screen()
        {
            InitializeComponent();
        }
        string connectionadress = $"server={ConfigManager.Settings.ConnectionInfo.ipadress};user=root;password=admin;database=InkWatch_db;port={ConfigManager.Settings.ConnectionInfo.port}";

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

            string user_name = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();

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
                MessageBox.Show("Veritabanı Hatası: " + ex.Message,"Veritabanı Sorunu",MessageBoxButtons.OK,MessageBoxIcon.Error);



            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                db_settings db_set = new db_settings();
                db_set.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Hata ile karşılaşıldı! " + ex.Message); }
            
        }
    }
}
