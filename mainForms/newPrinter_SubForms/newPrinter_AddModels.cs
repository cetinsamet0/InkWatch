using InkWatch.configs;
using InkWatch.styling;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkWatch.mainForms.newPrinter_SubForms
{
    public partial class newPrinter_AddModels : BaseForm
    {
        private main _addModels;
        string connectionadress = $"server={ConfigManager.Settings.ConnectionInfo.ipadress};user=root;password=admin;database=InkWatchDB;port={ConfigManager.Settings.ConnectionInfo.port}";

        public newPrinter_AddModels(main addModels)
        {
            InitializeComponent();
            _addModels = addModels;

        }

        private void newPrinter_AddModels_Load(object sender, EventArgs e)
        {
            brandadd();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void brandadd()
        {
            string brandquery = "SELECT brand_id,brand_name FROM tbl_brands";
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionadress))
                {
                    MySqlCommand brandadd = new MySqlCommand(brandquery, con);
                    MySqlDataAdapter brandadapter = new MySqlDataAdapter(brandadd);
                    DataTable branddt = new DataTable();
                    brandadapter.Fill(branddt);

                    // "Lütfen bir marka seçiniz" satırı ekle
                    DataRow newRow = branddt.NewRow();
                    newRow["brand_id"] = DBNull.Value;
                    newRow["brand_name"] = "Lütfen bir marka seçiniz";
                    branddt.Rows.InsertAt(newRow, 0);

                    comboBox1.DisplayMember = "brand_name";
                    comboBox1.ValueMember = "brand_id";
                    comboBox1.DataSource = branddt;

                    // comboBox2 için de aynı işlemi yap
                    DataTable branddt2 = branddt.Copy();
                    comboBox2.DisplayMember = "brand_name";
                    comboBox2.ValueMember = "brand_id";
                    comboBox2.DataSource = branddt2;

                    // İlk satırı seçili yap
                    comboBox1.SelectedIndex = 0;
                    comboBox2.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program bir hatayla karşılaştı: " + ex.Message);
            }
        }


        string secilenDosyaYolu = "";
        OpenFileDialog ofd = new OpenFileDialog();
        private byte[] imageBytes;
        int selectedBrandId;
        int selectedBrandId2;
        int selectedModelId;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox1.SelectedIndex == -1 || comboBox1.SelectedValue == DBNull.Value)
                return;
            selectedBrandId = Convert.ToInt32(comboBox1.SelectedValue);
            MessageBox.Show("Seçilen Marka ID: " + selectedBrandId.ToString());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //model resmi seçme butonu
            ofd.Title = "Resim Seç";
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                secilenDosyaYolu = ofd.FileName;
                pictureBox2.Image = Image.FromFile(secilenDosyaYolu);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                string filePath = ofd.FileName;
                imageBytes = File.ReadAllBytes(filePath);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //model kaydetme butonu

            if (string.IsNullOrEmpty(textBox1.Text) || selectedBrandId <= 0 || imageBytes == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve bir resim seçin.");
                return;
            }
            using (MySqlConnection con = new MySqlConnection(connectionadress))
            {
                string savecommamd = "INSERT INTO tbl_models (model_name, brand_id, model_logo) VALUES (@modelName, @brandId, @modelImage)";
                using (MySqlCommand savecommand = new MySqlCommand(savecommamd, con))
                {
                    savecommand.Parameters.AddWithValue("@modelName", textBox1.Text);
                    savecommand.Parameters.AddWithValue("@brandId", selectedBrandId);
                    savecommand.Parameters.AddWithValue("@modelImage", imageBytes);
                    try
                    {
                        con.Open();
                        int rowsAffected = savecommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Model başarıyla kaydedildi.");

                        }
                        else
                        {
                            MessageBox.Show("Model kaydedilemedi. Lütfen tekrar deneyin.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }


            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null || comboBox2.SelectedIndex == -1 || comboBox2.SelectedValue == DBNull.Value)
                return;
            selectedBrandId2 = Convert.ToInt32(comboBox2.SelectedValue);
            using (MySqlConnection conn = new MySqlConnection(connectionadress))
            {
                string modeladdquery = "SELECT model_id, model_name FROM tbl_models WHERE brand_id = @brandId";
                using (MySqlCommand modeladdcommand = new MySqlCommand(modeladdquery, conn))
                {
                    modeladdcommand.Parameters.AddWithValue("@brandId", selectedBrandId2);
                    try
                    {
                        conn.Open();
                        MySqlDataAdapter modeladdadapter = new MySqlDataAdapter(modeladdcommand);
                        DataTable modeladddt = new DataTable();
                        modeladdadapter.Fill(modeladddt);
                        // "Lütfen bir model seçiniz" satırı ekle
                        DataRow newRow = modeladddt.NewRow();
                        newRow["model_id"] = DBNull.Value;
                        newRow["model_name"] = "Lütfen bir model seçiniz";
                        modeladddt.Rows.InsertAt(newRow, 0);
                        comboBox3.DisplayMember = "model_name";
                        comboBox3.ValueMember = "model_id";
                        comboBox3.DataSource = modeladddt;
                        // İlk satırı seçili yap
                        comboBox3.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}