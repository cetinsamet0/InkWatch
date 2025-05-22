using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InkWatch.styling
{
    public class BaseForm : Form
    {
        // Sürükleme için gerekli WinAPI
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(nint hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private System.Windows.Forms.Timer fadeTimer;
        

        private int cornerRadius = 20;

        public BaseForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            Padding = new Padding(4);
            BackColor = Color.FromArgb(34, 36, 38);
            DoubleBuffered = true;
            Load += BaseForm_Load;
            MouseDown += BaseForm_MouseDown;
            Paint += BaseForm_Paint;

            


           
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
        }

       
        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void BaseForm_Paint(object sender, PaintEventArgs e)
        {
            int borderThickness = 1;
            Color borderColor = Color.White;

            // Kenarlık çiz
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                borderColor, borderThickness, ButtonBorderStyle.Solid,
                borderColor, borderThickness, ButtonBorderStyle.Solid,
                borderColor, borderThickness, ButtonBorderStyle.Solid,
                borderColor, borderThickness, ButtonBorderStyle.Solid);
        }

        

       /* protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            
        }*/
    }
}
