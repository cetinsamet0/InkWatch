using InkWatch.styling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkWatch.mainForms
{

    public partial class faultrecord : BaseForm
    {
        private main _anaForm;
        public faultrecord(main anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }

        private void faultrecord_Load(object sender, EventArgs e)
        {
            this.Location = _anaForm.Location;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            _anaForm.Show();
        }
    }
}
