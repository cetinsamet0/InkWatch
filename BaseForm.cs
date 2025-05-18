using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InkWatch
{
    public class BaseForm : Form
    {
        // Sürükleme için gerekli WinAPI
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private System.Windows.Forms.Timer fadeTimer;
        

        private int cornerRadius = 20;

        public BaseForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(4);
            this.BackColor = Color.White; // Border rengi
            this.DoubleBuffered = true;

            this.Opacity = 0; // Fade-in için başta görünmez
            this.Load += BaseForm_Load;
            this.MouseDown += BaseForm_MouseDown;
            this.Paint += BaseForm_Paint;

            //SetRoundedRegion();

            // Fade-in animasyon
            fadeTimer = new System.Windows.Forms.Timer();
            
            fadeTimer.Interval = 20;
            fadeTimer.Tick += FadeTimer_Tick;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                fadeTimer.Stop();
            }
        }

        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void BaseForm_Paint(object sender, PaintEventArgs e)
        {
            int borderThickness = 1;
            Color borderColor = Color.White;

            // Kenarlık çiz
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                borderColor, borderThickness, ButtonBorderStyle.Solid,
                borderColor, borderThickness, ButtonBorderStyle.Solid,
                borderColor, borderThickness, ButtonBorderStyle.Solid,
                borderColor, borderThickness, ButtonBorderStyle.Solid);
        }

        //private void SetRoundedRegion()
        //{
        //    var path = new GraphicsPath();
        //    Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);

        //    int r = cornerRadius;

        //    path.AddArc(bounds.X, bounds.Y, r, r, 180, 90);
        //    path.AddArc(bounds.Right - r, bounds.Y, r, r, 270, 90);
        //    path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
        //    path.AddArc(bounds.X, bounds.Bottom - r, r, r, 90, 90);
        //    path.CloseFigure();

        //    this.Region = new Region(path);
        //}

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            /*SetRoundedRegion();*/ // Yuvarlak köşe resize sonrası da korunsun
        }
    }
}
