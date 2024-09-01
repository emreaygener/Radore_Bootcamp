namespace Radore_OgrenciForm_Odev
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblBolum = new Label();
            lblSonuc = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            btnKayıt = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(137, 87);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(137, 130);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(137, 177);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(42, 15);
            lblBolum.TabIndex = 2;
            lblBolum.Text = "Bölüm";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(137, 325);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(76, 15);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "Kayıt Sonucu";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(312, 84);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(312, 127);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(312, 174);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(100, 23);
            txtBolum.TabIndex = 6;
            // 
            // btnKayıt
            // 
            btnKayıt.Location = new Point(312, 242);
            btnKayıt.Name = "btnKayıt";
            btnKayıt.Size = new Size(100, 46);
            btnKayıt.TabIndex = 7;
            btnKayıt.Text = "Kayıt";
            btnKayıt.UseVisualStyleBackColor = true;
            btnKayıt.Click += btnKayıt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 450);
            Controls.Add(btnKayıt);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblSonuc);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblBolum;
        private Label lblSonuc;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Button btnKayıt;
    }
}
