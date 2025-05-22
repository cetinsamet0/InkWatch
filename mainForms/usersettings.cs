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
    public partial class usersettings : BaseForm
    {
        private main _anaForm;
        public usersettings(main anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }

        private void usersettings_Load(object sender, EventArgs e)
        {
            this.Location = anaForm.Location;
        }
    }
}
