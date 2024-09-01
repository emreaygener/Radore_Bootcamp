namespace LogForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogType = new Label();
            cmbLogType = new ComboBox();
            Durum = new Label();
            txtDurum = new TextBox();
            btnKaydet = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // LogType
            // 
            LogType.AutoSize = true;
            LogType.Location = new Point(366, 100);
            LogType.Margin = new Padding(4, 0, 4, 0);
            LogType.Name = "LogType";
            LogType.Size = new Size(84, 25);
            LogType.TabIndex = 0;
            LogType.Text = "Log Type";
            // 
            // cmbLogType
            // 
            cmbLogType.FormattingEnabled = true;
            cmbLogType.Items.AddRange(new object[] { "Seçiniz", "DbLogger", "XmlLogger", "JsonLogger" });
            cmbLogType.Location = new Point(609, 95);
            cmbLogType.Margin = new Padding(4, 5, 4, 5);
            cmbLogType.Name = "cmbLogType";
            cmbLogType.Size = new Size(171, 33);
            cmbLogType.TabIndex = 1;
            // 
            // Durum
            // 
            Durum.AutoSize = true;
            Durum.Location = new Point(366, 207);
            Durum.Margin = new Padding(4, 0, 4, 0);
            Durum.Name = "Durum";
            Durum.Size = new Size(67, 25);
            Durum.TabIndex = 2;
            Durum.Text = "Durum";
            // 
            // txtDurum
            // 
            txtDurum.Location = new Point(639, 202);
            txtDurum.Margin = new Padding(4, 5, 4, 5);
            txtDurum.Name = "txtDurum";
            txtDurum.Size = new Size(141, 31);
            txtDurum.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(639, 337);
            btnKaydet.Margin = new Padding(4, 5, 4, 5);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(143, 48);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(366, 487);
            lblSonuc.Margin = new Padding(4, 0, 4, 0);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(61, 25);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblSonuc);
            Controls.Add(btnKaydet);
            Controls.Add(txtDurum);
            Controls.Add(Durum);
            Controls.Add(cmbLogType);
            Controls.Add(LogType);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LogType;
        private ComboBox cmbLogType;
        private Label Durum;
        private TextBox txtDurum;
        private Button btnKaydet;
        private Label lblSonuc;
    }
}
