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

namespace InkWatch.mainForms.newPrinter_SubForms
{
    public partial class newPrinter_AddModels : BaseForm
    {
        private main _addModels;
        public newPrinter_AddModels(main addModels)
        {
            InitializeComponent();
            _addModels = addModels;
            this.StartPosition = FormStartPosition.Manual;

            // Ortalamak için:
            int x = _addModels.Location.X + (_addModels.Width - this.Width) / 2;
            int y = _addModels.Location.Y + (_addModels.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void newPrinter_AddModels_Load(object sender, EventArgs e)
        {
            this.Location = _addModels.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}