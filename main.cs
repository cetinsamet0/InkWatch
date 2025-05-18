using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace InkWatch
{
    public partial class main : InkWatch.BaseForm
    {
    
        // WinAPI fonksiyonlarý
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Sürükleme mesaj sabitleri
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;



        public main()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(34, 36, 38); // içerik rengi
        }


        private void main_Load(object sender, EventArgs e)
        {
            FormStyler.ButtonStyler(button1);
            FormStyler.ButtonStyler(button2);
            FormStyler.ButtonStyler(button3);
            FormStyler.ButtonStyler(button4);
            FormStyler.ButtonStyler(button5);
            FormStyler.ButtonStyler(button6);
            FormStyler.ButtonStyler(button7);
            FormStyler.DatagridViewStyle(dataGridView1);

            
            bool hideApps = ConfigManager.Settings.AppSettings.hideallwindows;
            if (hideApps = false)
            {
                ShowDesktop();
            }

            //!!!!Burdaki yorum satýrýný ileride kaldýr
            this.Hide();
            login_Screen loginscrenn = new login_Screen();
            loginscrenn.ShowDialog();
            
            

            label1.Text = $"Kullanýcý: {loginscrenn.user_name}";

            string connectionString = "server=localhost;user=root;password=admin;database=InkWatch_db;port=3306";
            string query = "SELECT \r\n    p.printer_id,\r\n    b.brand_name,\r\n    m.model_name,\r\n    p.printer_ip,\r\n    p.printer_owner,\r\n    p.log_id,\r\n    p.printer_changepart_log\r\nFROM \r\n    tbl_printers p\r\nJOIN \r\n    tbl_brands b ON p.brand_id = b.brand_id\r\nJOIN \r\n    tbl_models m ON p.model_id = m.model_id;";

            using (MySqlConnection con = new MySqlConnection(connectionString))

            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
           
        }

        private void ShowDesktop()
        {
            Process.Start("powershell", "-command \"(New-Object -ComObject shell.application).MinimizeAll()\"");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
