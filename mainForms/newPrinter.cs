using InkWatch.configs;
using InkWatch.mainForms.newPrinter_SubForms;
using InkWatch.styling;
using MySql.Data.MySqlClient;
using System.Data;
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
) l ON p.printer_id = l.printer_id;
";
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
        private void brandadd()
        {
            string brandquery = "SELECT brand_name FROM tbl_brands";
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionadress))
                {
                    MySqlCommand brandadd = new MySqlCommand(brandquery, con);
                    MySqlDataAdapter brandadapter = new MySqlDataAdapter(brandadd);
                    DataTable branddt = new DataTable();
                    brandadapter.Fill(branddt);
                    comboBox1.DataSource = branddt;
                    comboBox1.DisplayMember = "brand_name";


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
                    modelsadd.Parameters.AddWithValue("@BrandID", selectedBrandID);
                    MySqlDataAdapter modelsadapter = new MySqlDataAdapter(modelsadd);
                    DataTable modelsdt = new DataTable();
                    modelsadapter.Fill(modelsdt);
                    comboBox2.DataSource = modelsdt;
                    comboBox2.DisplayMember = "model_name";


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
        int selectedBrandID = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedBrandID = comboBox1.SelectedIndex + 1;
            modelsadd();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int selectedBrandName = comboBox1.SelectedIndex + 1;
            int selectedModelName = comboBox2.SelectedIndex + 1;
            string newPrinterSerialNumber = textBox2.Text;
            int selectedDepartmantName = comboBox3.SelectedIndex + 1;
            string newPrinterIpAdress = textBox1.Text;
            string addNewPrinterQuerry = @"INSERT INTO tbl_printers (brand_id, model_id, departmant_id, printer_sn, printer_ip)
VALUES (@brandID, @modelID, @departmantID, @serialNumber , @ipAdress);";
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionadress))
                    {
                        MySqlCommand addNewPrinterCommand = new MySqlCommand(addNewPrinterQuerry, conn);
                        addNewPrinterCommand.Parameters.AddWithValue("@brandID", selectedBrandName);
                        addNewPrinterCommand.Parameters.AddWithValue("@modelID", selectedModelName);
                        addNewPrinterCommand.Parameters.AddWithValue("@departmantID", selectedDepartmantName);
                        addNewPrinterCommand.Parameters.AddWithValue("@serialNumber", newPrinterSerialNumber);
                        addNewPrinterCommand.Parameters.AddWithValue("@ipAdress", newPrinterIpAdress);
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




        }

        private void button1_Click(object sender, EventArgs e)
        {
            newPrinter_AddBrands addBrands = new newPrinter_AddBrands();
            addBrands.ShowDialog();

        }
    }
}
