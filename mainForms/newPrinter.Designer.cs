namespace InkWatch.mainForms
{
    partial class newPrinter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newPrinter));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button7 = new Button();
            pictureBox3 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.closebtn;
            pictureBox2.Location = new Point(1125, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += comboBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 12);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "Marka Seç:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 61);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 8;
            label2.Text = "Model Seç:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(101, 79);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(252, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 12);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 11;
            label3.Text = "Kime Verilecek:";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(373, 30);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(239, 23);
            comboBox3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(373, 79);
            textBox1.MaxLength = 12;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 5;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 61);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 13;
            label4.Text = "IP Adresi:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 23);
            textBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 114);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 15;
            label5.Text = "Seri Numarası:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1181, 412);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Location = new Point(373, 129);
            dateTimePicker1.Margin = new Padding(0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(239, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 111);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 18;
            label6.Text = "Teslim Tarihi:";
            // 
            // button1
            // 
            button1.Location = new Point(772, 27);
            button1.Name = "button1";
            button1.Size = new Size(197, 34);
            button1.TabIndex = 9;
            button1.Text = "Marka İşlemleri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(772, 72);
            button2.Name = "button2";
            button2.Size = new Size(197, 34);
            button2.TabIndex = 9;
            button2.Text = "Model İşlemleri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(772, 118);
            button3.Name = "button3";
            button3.Size = new Size(197, 34);
            button3.TabIndex = 10;
            button3.Text = "Departman İşlemleri";
            button3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(627, 27);
            button7.Name = "button7";
            button7.Size = new Size(139, 54);
            button7.TabIndex = 7;
            button7.Text = "Yazıcıyı Ekle";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.no_image_logo;
            pictureBox3.Location = new Point(982, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(130, 130);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(627, 87);
            button4.Name = "button4";
            button4.Size = new Size(139, 65);
            button4.TabIndex = 8;
            button4.Text = "Seçili Yazıcıyı Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // newPrinter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 38);
            ClientSize = new Size(1200, 600);
            Controls.Add(button4);
            Controls.Add(pictureBox3);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "newPrinter";
            StartPosition = FormStartPosition.CenterParent;
            Text = "newPrinter";
            Load += newPrinter_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button7;
        private PictureBox pictureBox3;
        private Button button4;
    }
}