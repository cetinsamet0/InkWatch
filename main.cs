using System.Diagnostics;

namespace InkWatch
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
      
        private void main_Load(object sender, EventArgs e)
        {
            bool hideApps = ConfigManager.Settings.AppSettings.hideallwindows;
            if (hideApps = false)
            {
                ShowDesktop();
            }
            this.Hide();
            login_Screen loginscrenn = new login_Screen();
            loginscrenn.ShowDialog();
            //main anaform = new main();
            
        }
        private void ShowDesktop()
        {
            Process.Start("powershell", "-command \"(New-Object -ComObject shell.application).MinimizeAll()\"");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
