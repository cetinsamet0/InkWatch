using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InkWatch.configs;
using InkWatch.styling;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.X509.Store;

namespace InkWatch.mainForms.newPrinter_SubForms
{
    public partial class newPrinter_AddDepartmant : BaseForm
    {
        public newPrinter_AddDepartmant()
        {
            InitializeComponent();

        }
        string connectionadress = $"server={ConfigManager.Settings.ConnectionInfo.ipadress};user=root;password=admin;database=InkWatchDB;port={ConfigManager.Settings.ConnectionInfo.port}";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newPrinter_AddDepartmant_Load(object sender, EventArgs e)
        {
            addDepartmantName();
        }
        private void addDepartmantName()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionadress))
            {
                comboBox1.Items.Clear();
                conn.Open();
                string addDepartmantQuery = "SELECT * FROM tbl_departmants";
                using (MySqlCommand cmd = new MySqlCommand(addDepartmantQuery, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string departmantName = reader.GetString("departmant_name");
                            comboBox1.Items.Add(departmantName);
                        }
                    }
                }
            }
        }

        string departmentName = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == String.Empty)
            {
                MessageBox.Show("Lütfen departman adını giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            departmentName = textBox1.Text;
            using (MySqlConnection conn = new MySqlConnection(connectionadress))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tbl_departmants WHERE departmant_name = @departmentName";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@departmentName", departmentName);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Bu departman zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                    }
                    else
                    {
                        string departmantadd = "INSERT INTO tbl_departmants (departmant_name) VALUES (@departmentName)";
                        using (MySqlCommand cmd2 = new MySqlCommand(departmantadd, conn))
                        {
                            cmd2.Connection = conn;
                            cmd2.CommandText = departmantadd;
                            cmd2.Parameters.AddWithValue("@departmentName", departmentName);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Departman başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Text = "";
                        }
                    }
                }
                addDepartmantName();
            }

        }

        //silme işlemimini departman idye göre yapmalı çünkü tbl_printers tablosunda departman adı değil idsi var sadece
        private void button2_Click(object sender, EventArgs e)
        {
            int selectedDeletedDepartmant = comboBox1.SelectedIndex;
            if (selectedDeletedDepartmant < 0 || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz departmanı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedDepartmentName = comboBox1.SelectedItem.ToString();
            DialogResult soru = MessageBox.Show("Seçilen Departman: " + selectedDepartmentName, "Departman Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (soru != DialogResult.Yes)
            {
                MessageBox.Show("Departman silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionadress))
            {
                conn.Open();
                string checkingquery = "SELECT COUNT(*) FROM tbl_printers WHERE departmant_id = @departmantName";
                using (MySqlCommand command2 = new MySqlCommand(checkingquery, conn))
                {
                    command2.Parameters.AddWithValue("@departmantName", selectedDepartmentName);
                    int count = Convert.ToInt32(command2.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Bu departmana ait yazıcılar var, ilk önce onları kaldırmalısınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string deleteDepartmant = "DELETE FROM tbl_departmants WHERE departmant_name = @departmantName";
                using (MySqlCommand cmd = new MySqlCommand(deleteDepartmant, conn))
                {
                    cmd.Parameters.AddWithValue("@departmantName", selectedDepartmentName);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Departman başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.Items.RemoveAt(selectedDeletedDepartmant);
                }
            }
        }
    }
}
