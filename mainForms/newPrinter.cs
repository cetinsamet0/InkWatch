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

        private void newPrinter_Load(object sender, EventArgs e)
        {
            this.Location = _anaForm.Location;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
