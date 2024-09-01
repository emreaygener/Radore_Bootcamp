namespace WinFormsApp
{
    partial class Form2
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
            lblSayi1 = new Label();
            lblSayi2 = new Label();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            btnHesapla = new Button();
            SuspendLayout();
            // 
            // lblSayi1
            // 
            lblSayi1.AutoSize = true;
            lblSayi1.Location = new Point(148, 92);
            lblSayi1.Name = "lblSayi1";
            lblSayi1.Size = new Size(51, 20);
            lblSayi1.TabIndex = 0;
            lblSayi1.Text = "Sayı 1:";
            // 
            // lblSayi2
            // 
            lblSayi2.AutoSize = true;
            lblSayi2.Location = new Point(148, 139);
            lblSayi2.Name = "lblSayi2";
            lblSayi2.Size = new Size(51, 20);
            lblSayi2.TabIndex = 1;
            lblSayi2.Text = "Sayı 2:";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(240, 89);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(125, 27);
            txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(240, 136);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(125, 27);
            txtSayi2.TabIndex = 3;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(271, 225);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(94, 29);
            btnHesapla.TabIndex = 4;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHesapla);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(lblSayi2);
            Controls.Add(lblSayi1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSayi1;
        private Label lblSayi2;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Button btnHesapla;
    }
}