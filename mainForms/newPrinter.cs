using InkWatch.configs;
using InkWatch.mainForms.newPrinter_SubForms;
using InkWatch.styling;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
namespace InkWatch.mainForms
{
    public partial class newPrinter : BaseForm
    {
        private main _anaForm;
        public newPrinter(main anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            _anaForm.Show();
            this.Close();
            _anaForm.Location = this.Location;


        }

        string connectionadress = $"server={ConfigManager.Settings.ConnectionInfo.ipadress};user=admin;password=admin;database=InkWatchDB;port={ConfigManager.Settings.ConnectionInfo.port}";

        private void newPrinter_Load(object sender, EventArgs e)
        {
            this.Location = _anaForm.Location;
            fillTable();
            brandadd();
            departmantsadd();
            ResmiGetirVeGoster();

        }
        private void ResmiGetirVeGoster()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionadress))
            {
                conn.Open();
                string query = "SELECT brand_logo FROM tbl_brands WHERE brand_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", selectedBrandId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        { 
                            byte[] resimVerisi = reader["brand_logo"] as byte[];
                            if (resimVerisi != null)
                            {
                                using (MemoryStream ms = new MemoryStream(resimVerisi))
                                {
                                    pictureBox1.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void fillTable()
        {
            FormStyler.DatagridViewStyle(dataGridView1);
            string query = @"SELECT 
            b.brand_name       AS 'Yazıcı Markası',
            m.model_name       AS 'Yazıcı Modeli',
            d.departmant_name  AS 'Departman',
            p.printer_sn       AS 'Seri Numarası',
            p.printer_ip       AS 'IP Adresi',
            p.delivery_date    AS 'Teslim Tarihi',
            l.action           AS 'Son İşlem',
            l.timestamp        AS 'İşlem Tarihi'
            FROM tbl_printers p
            JOIN tbl_brands b ON p.brand_id = b.brand_id
            JOIN tbl_models m ON p.model_id = m.model_id
            JOIN tbl_departmants d ON p.departmant_id = d.departmant_id
            LEFT JOIN (
            SELECT l1.*
            FROM tbl_logs l1
            INNER JOIN (
            SELECT printer_id, MAX(timestamp) AS max_time
            FROM tbl_logs
            GROUP BY printer_id
            ) l2 ON l1.printer_id = l2.printer_id AND l1.timestamp = l2.max_time
            ) l ON p.printer_id = l.printer_id
            ORDER BY l.timestamp DESC";
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionadress))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program bir hatayla karşılaştı: " + ex.Message);

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



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program bir hatayla karşılaştı: " + ex.Message);

            }

        }

        private void modelsadd()
        {
            string modelsaddquerry = @"SELECT 
tbl_brands.brand_id,
tbl_brands.brand_name,
tbl_models.model_id,
tbl_models.model_name
FROM 
tbl_brands
INNER JOIN 
tbl_models ON tbl_brands.brand_id = tbl_models.brand_id
WHERE 
tbl_brands.brand_id = @BrandID;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionadress))
                {

                    MySqlCommand modelsadd = new MySqlCommand(modelsaddquerry, con);
                    modelsadd.Parameters.AddWithValue("@BrandID", selectedBrandId);
                    MySqlDataAdapter modelsadapter = new MySqlDataAdapter(modelsadd);
                    DataTable modelsdt = new DataTable();
                    modelsadapter.Fill(modelsdt);
                    comboBox2.DisplayMember = "model_name";
                    comboBox2.ValueMember = "model_id";
                    comboBox2.DataSource = modelsdt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program bir hatayla karşılaştı: " + ex.Message);

            }
        }
        private void departmantsadd()
        {
            string departmentsaddquerry = @"Select departmant_name from tbl_departmants";
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionadress))
                {
                    MySqlCommand departmansadd = new MySqlCommand(departmentsaddquerry, con);
                    MySqlDataAdapter departmansadapter = new MySqlDataAdapter(departmansadd);
                    DataTable departmentsdt = new DataTable();
                    departmansadapter.Fill(departmentsdt);
                    comboBox3.DataSource = departmentsdt;
                    comboBox3.DisplayMember = "departmant_name";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Program bir hatayla karşılaştı: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam, nokta ve kontrol tuşlarına (silme, backspace) izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // karakteri engelle
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                selectedBrandId = (int)comboBox1.SelectedValue;
                modelsadd();
            }
            else
            {
                MessageBox.Show("Hata!");
            }
           

            try
            {

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

                            pictureBox3.Image = Properties.Resources.no_image_logo;
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        int selectedBrandId;
        int selectedModelId;
        private void button7_Click(object sender, EventArgs e)
        {
            selectedBrandId = (int)comboBox1.SelectedValue;
            selectedModelId = (int)comboBox2.SelectedValue;
            string newPrinterSerialNumber = textBox2.Text;
            int selectedDepartmantName = comboBox3.SelectedIndex + 1;
            string newPrinterIpAdress = textBox1.Text;
            string addNewPrinterQuerry = @"INSERT INTO tbl_printers (brand_id, model_id, departmant_id, printer_sn, printer_ip, delivery_date)
VALUES (@brandID, @modelID, @departmantID, @serialNumber , @ipAdress , @deliveryDate);";
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionadress))
                    {
                        MySqlCommand addNewPrinterCommand = new MySqlCommand(addNewPrinterQuerry, conn);
                        addNewPrinterCommand.Parameters.AddWithValue("@brandID", selectedBrandId);
                        addNewPrinterCommand.Parameters.AddWithValue("@modelID", selectedModelId);
                        addNewPrinterCommand.Parameters.AddWithValue("@departmantID", selectedDepartmantName);
                        addNewPrinterCommand.Parameters.AddWithValue("@serialNumber", newPrinterSerialNumber);
                        addNewPrinterCommand.Parameters.AddWithValue("@ipAdress", newPrinterIpAdress);
                        addNewPrinterCommand.Parameters.AddWithValue("@deliveryDate", dateTimePicker1.Value);
                        conn.Open();
                        addNewPrinterCommand.ExecuteNonQuery();
                        conn.Close();

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Program bir hatayla karşılaştı: " + ex.Message);
                }
                MessageBox.Show("Yeni yazıcı sisteme eklendi!");
            }
            else
            {
                MessageBox.Show("Tüm alanları eksiksiz doldurduğunuzdan emin olunuz!", "Seri Numarası Veya Ip Adresi Girilmemiş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            fillTable();



        }
        public Point location;
        private void button1_Click(object sender, EventArgs e)
        {
            location = this.Location;
            
            newPrinter_AddBrands addBrands = new newPrinter_AddBrands(_anaForm);
            addBrands.ShowDialog();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedModelId = (int)comboBox2.SelectedValue;
            
        }
    }
}
