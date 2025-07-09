using InkWatch.configs;
using InkWatch.styling;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkWatch.mainForms.newPrinter_SubForms
{
    public partial class newPrinter_AddBrands : BaseForm
    {
        private main _addBrand;
        string connectionadress = $"server={ConfigManager.Settings.ConnectionInfo.ipadress};user=root;password=admin;database=InkWatchDB;port={ConfigManager.Settings.ConnectionInfo.port}";

        public newPrinter_AddBrands(main addBrand)
        {
            InitializeComponent();
            _addBrand = addBrand;

        }

        private void newPrinter_AddBrands_Load(object sender, EventArgs e)
        {
            this.Location = _addBrand.location;
            brandadd();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        string secilenDosyaYolu = "";
        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {

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
        private byte[] imageBytes;
        private void button2_Click(object sender, EventArgs e)
        {
            if (imageBytes == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionadress))
            {
                conn.Open();
                string sql = "INSERT INTO tbl_brands (brand_name, brand_logo) VALUES (@brandName,@logo)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@brandName", textBox1.Text.ToString());
                    cmd.Parameters.Add("@logo", MySqlDbType.MediumBlob).Value = imageBytes;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Logo başarıyla yüklendi.");
                }
            }
        }
        int selectedBrandId;
        int selectedBrandIdDelete;
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox1.SelectedIndex == -1 || comboBox1.SelectedValue == DBNull.Value)
                return;
            MessageBox.Show(selectedBrandId.ToString());
            try
            {
                selectedBrandId = Convert.ToInt32(comboBox1.SelectedValue);

                using (MySqlConnection conn = new MySqlConnection(connectionadress))
                {
                    conn.Open();
                    string sql = "SELECT brand_logo FROM tbl_brands WHERE brand_id = @brandId";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@brandId", selectedBrandId);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            byte[] logoBytes = (byte[])result;
                            using (MemoryStream ms = new MemoryStream(logoBytes))
                            {
                                pictureBox3.Image = Image.FromStream(ms);
                                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                        else
                        {
                            pictureBox3.Image = Properties.Resources.no_image_logo; // Varsayılan logo resmi
                            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null || comboBox2.SelectedIndex == -1 || comboBox2.SelectedValue == DBNull.Value)
                return;
           
            try
            {
                selectedBrandIdDelete = Convert.ToInt32(comboBox2.SelectedValue);
                
                using (MySqlConnection conn = new MySqlConnection(connectionadress))
                {
                    conn.Open();
                    string sql = "SELECT brand_logo FROM tbl_brands WHERE brand_id = @brandId";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@brandId", selectedBrandIdDelete);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            byte[] logoBytes = (byte[])result;
                            using (MemoryStream ms = new MemoryStream(logoBytes))
                            {
                                pictureBox4.Image = Image.FromStream(ms);
                                pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                        else
                        {
                            pictureBox4.Image = Properties.Resources.no_image_logo; // Varsayılan logo resmi
                            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                selectedBrandIdDelete = Convert.ToInt32(comboBox2.SelectedValue);

                // Önce bu brand_id'nin tbl_printers tablosunda kullanılıp kullanılmadığını kontrol et
                using (MySqlConnection conn = new MySqlConnection(connectionadress))
                {
                    conn.Open();
                    string checkSql = "SELECT COUNT(*) FROM tbl_printers WHERE brand_id = @brandId";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@brandId", selectedBrandIdDelete);
                        int printerCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (printerCount > 0)
                        {
                            MessageBox.Show("Bu marka, yazıcılar tablosunda kullanıldığı için silinemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    // Silme işlemi
                    string sql = "DELETE FROM tbl_brands WHERE brand_id = @brandId";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@brandId", selectedBrandIdDelete);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Marka başarıyla silindi.");
                            brandadd(); // Markaları yeniden yükle
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız oldu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
