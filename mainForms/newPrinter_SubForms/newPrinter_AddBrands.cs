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
        string connectionadress = $"server={ConfigManager.Settings.ConnectionInfo.ipadress};user=admin;password=admin;database=InkWatchDB;port={ConfigManager.Settings.ConnectionInfo.port}";

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox1.SelectedIndex == -1)
                return;

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
                           
                            MessageBox.Show("Seçilen markanın logosu bulunamadı.", "Logo Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
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
                    comboBox1.DisplayMember = "brand_name";
                    comboBox1.ValueMember = "brand_id";
                    comboBox1.DataSource = branddt;
                    comboBox2.DisplayMember = "brand_name";
                    comboBox2.ValueMember = "brand_id";
                    comboBox2.DataSource = branddt;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program bir hatayla karşılaştı: " + ex.Message);

            }

        }
    }
}
