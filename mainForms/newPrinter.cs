using InkWatch.configs;
using InkWatch.styling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
            string brandquery = "SELECT brand_name FROM tbl_brands";
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionadress))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MySqlCommand brandadd = new MySqlCommand(brandquery, con);
                    MySqlDataAdapter brandadapter = new MySqlDataAdapter(brandadd);
                    DataTable branddt = new DataTable();
                    brandadapter.Fill(branddt);
                    comboBox1.DataSource = branddt;
                    comboBox1.DisplayMember = "brand_name";
                    

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Program bir hatayla karşılaştı: " + ex.Message);
            
            }
            
            
        }
        private void brandadd()
        {
            

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
}
}
