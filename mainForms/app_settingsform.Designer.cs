namespace InkWatch.mainForms
{
    partial class app_settingsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app_settingsform));
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            labelSaat = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(38, 96);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(277, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Program açıldığında her şeyi gizle.\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // labelSaat
            // 
            labelSaat.AutoSize = true;
            labelSaat.FlatStyle = FlatStyle.Flat;
            labelSaat.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelSaat.ForeColor = SystemColors.ButtonFace;
            labelSaat.Location = new Point(76, 25);
            labelSaat.Name = "labelSaat";
            labelSaat.Size = new Size(257, 30);
            labelSaat.TabIndex = 2;
            labelSaat.Text = "dd.MM.yyyy HH:mm:ss";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.question;
            pictureBox3.Location = new Point(612, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(7, 364);
            label1.Name = "label1";
            label1.Size = new Size(377, 40);
            label1.TabIndex = 4;
            label1.Text = "*Değişiklikler otomatik kaydedilir. \r\nGeri tuşuna basıldığında uygulama yeniden başlatılır.\r\n";
            // 
            // app_settingsform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 417);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(checkBox1);
            Controls.Add(labelSaat);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "app_settingsform";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            TopMost = true;
            Load += app_settingsform_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Label labelSaat;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
    }
}