using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkWatch
{
    internal class FormStyler
    {
        public static void ButtonStyler(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.BackColor = Color.FromArgb(192, 66, 255);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Hover ve tıklama renkleri
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 52, 54);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 30, 32);
        }
        public static void DatagridViewStyle(DataGridView dataGridView)
        {

            // Modern stil – düz ve sade görünüm
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.RowHeadersVisible = false;
            dataGridView.BackgroundColor = Color.FromArgb(34, 36, 38);
            dataGridView.GridColor = Color.LightGray;

            // Alternatif satır rengi (açık gri)
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 42, 44);

            // Satır seçimi için renk
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215); // Windows mavi tonu
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Varsayılan satır yazı tipi ve renk
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView.DefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(34, 36, 38);

            // Başlık stilleri
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // mavi başlık
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Satır yüksekliği
            dataGridView.RowTemplate.Height = 32;

            // Kenar iç boşluk (padding)
            dataGridView.DefaultCellStyle.Padding = new Padding(4);

            // Sütunlar ekran boyuna göre otomatik genişlesin
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
