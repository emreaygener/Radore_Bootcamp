namespace WinFormsApp
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
            label1 = new Label();
            cmbOdemeTipi = new ComboBox();
            lblTutar = new Label();
            txtTutar = new TextBox();
            btnOdeme = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 96);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Tipi";
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Items.AddRange(new object[] { "Seciniz", "KrediKarti", "MailOrder", "ApplePay", "GooglePay" });
            cmbOdemeTipi.Location = new Point(228, 93);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(121, 23);
            cmbOdemeTipi.TabIndex = 1;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(128, 146);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(34, 15);
            lblTutar.TabIndex = 2;
            lblTutar.Text = "Tutar";
            lblTutar.Click += label2_Click;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(228, 143);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(121, 23);
            txtTutar.TabIndex = 3;
            // 
            // btnOdeme
            // 
            btnOdeme.Location = new Point(243, 222);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new Size(106, 45);
            btnOdeme.TabIndex = 4;
            btnOdeme.Text = "ÖDEME YAP";
            btnOdeme.UseVisualStyleBackColor = true;
            btnOdeme.Click += button1_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(128, 339);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(40, 15);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç";
            lblSonuc.Click += label2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnOdeme);
            Controls.Add(txtTutar);
            Controls.Add(lblTutar);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOdemeTipi;
        private Label lblTutar;
        private TextBox txtTutar;
        private Button btnOdeme;
        private Label lblSonuc;
    }
}
