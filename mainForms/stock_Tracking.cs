using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InkWatch.mainForms;
using InkWatch.styling;

namespace InkWatch
{
    public partial class stock_Tracking : BaseForm
    {
        private main _anaForm;
        public stock_Tracking(main anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _anaForm.Show();
            this.Close();
            _anaForm.Location = this.Location;
        }

        private void stock_Tracking_Load(object sender, EventArgs e)
        {
            Location = _anaForm.Location;
        }
    }
}
