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
// Hatanın nedeni: 'main' türü tanınmıyor çünkü C# büyük/küçük harfe duyarlıdır. 
// Sizin projenizde muhtemelen 'Main' veya 'main' adında bir sınıf var, ancak doğru şekilde 'using' yönergesiyle eklenmemiş veya yanlış adlandırılmış olabilir.
// Ayrıca, 'main' sınıfı başka bir ad alanında (namespace) tanımlıysa, tam adını (ör. InkWatch.main) kullanmalısınız.
// Çözüm: Eğer 'main' sınıfı InkWatch namespace'inde ise, doğrudan kullanabilirsiniz. 
// Fakat başka bir namespace'de ise, uygun using ekleyin veya tam adını kullanın.

// Örnek açıklama:
// 1. 'main' sınıfı tanımlı değilse veya yanlış yazılmışsa, derleyici bu hatayı verir.
// 2. 'main' sınıfı başka bir dosyada ve farklı bir namespace'de ise, using yönergesi eklenmeli.
// 3. C#'da sınıf isimleri genellikle büyük harfle başlar (Main). Küçük harfle başlatmak alışılmış değildir.

// Hatanın çözümü için şunları kontrol edin:
// - 'main' sınıfı gerçekten tanımlı mı?
// - Doğru namespace'de mi?
// - Doğru şekilde using eklenmiş mi?
// - Sınıf ismi büyük harfle mi başlamalı? (C# konvansiyonu gereği)
{
    public partial class fault_history : BaseForm
    {
        private main _anaForm;
        public fault_history(main anaForm)
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

        private void fault_history_Load(object sender, EventArgs e)
        {
            Location = _anaForm.Location;
        }
    }
}
