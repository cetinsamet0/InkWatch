using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using InkWatch.styling;
using InkWatch.configs;

namespace InkWatch.mainForms
{
    public partial class main : BaseForm
    {



        public main()
        {
            InitializeComponent();

        }


        private void main_Load(object sender, EventArgs e)
        {
            //Formu kiþiselleþtiren metotun çaðrýlmasý
            FormStyler.ButtonStyler(btnappsettings);
            FormStyler.ButtonStyler(button2);
            FormStyler.ButtonStyler(button3);
            FormStyler.ButtonStyler(button4);
            FormStyler.ButtonStyler(button5);
            FormStyler.ButtonStyler(button6);
            FormStyler.ButtonStyler(button7);
            FormStyler.DatagridViewStyle(dataGridView1);
            this.StartPosition = FormStartPosition.CenterScreen;

            //Appconfig okuyarak uygulamayý kiþiselleþtiren yer

            bool hideApps = ConfigManager.Settings.AppSettings.HideAllApps;
            if (hideApps)
            {
                ShowDesktop();
            }


            //!!!!Burdaki yorum satýrýný ileride kaldýr

            this.Hide();
            login_Screen loginscrenn = new login_Screen();
            loginscrenn.ShowDialog();
            label1.Text = $"Kullanýcý: {loginscrenn.user_name}";

            string connectionadress = $"server={ConfigManager.Settings.ConnectionInfo.ipadress};user=admin;password=admin;database=InkWatchDB;port={ConfigManager.Settings.ConnectionInfo.port}";

            //Örnek Sorgu datagridnasýl gözüküyor bakmak için
            string query = @"SELECT 
    b.brand_name       AS 'Yazýcý Markasý',
    m.model_name       AS 'Yazýcý Modeli',
    d.departmant_name  AS 'Departman',
    p.printer_sn       AS 'Seri Numarasý',
    p.printer_ip       AS 'IP Adresi',
    l.action           AS 'Son Ýþlem',
    l.timestamp        AS 'Ýþlem Tarihi'
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


            using (MySqlConnection con = new MySqlConnection(connectionadress))

            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }



        private void ShowDesktop()
        {
            Process.Start("powershell", "-command \"(New-Object -ComObject shell.application).MinimizeAll()\"");
        }

        private void btnappsettings_Click(object sender, EventArgs e)
        {
            app_settingsform appsettings = new app_settingsform();
            appsettings.ShowDialog();
        }
        public Point location;
        private void button2_Click(object sender, EventArgs e)
        {
            location = this.Location;
            newPrinter newprinterform = new newPrinter(this);
            newprinterform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            location = this.Location;
            faultrecord faultrecord = new faultrecord(this);
            faultrecord.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            location = this.Location;
            usersettings usersettings = new usersettings(this);
            usersettings.Show();
            this.Hide();
        }
    }
}
