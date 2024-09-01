namespace Radore_Serialization
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
            lblTelefon = new Label();
            lblDateOfBirth = new Label();
            lblDepartman = new Label();
            lblMaas = new Label();
            txtAd = new TextBox();
            txtTelefon = new TextBox();
            txtDepartman = new TextBox();
            txtMaas = new TextBox();
            dtpDOB = new DateTimePicker();
            btnSerialize = new Button();
            btnDeserialize = new Button();
            btnJsonSerialize = new Button();
            btnJsonDeserialize = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(177, 88);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(25, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(177, 128);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(48, 15);
            lblTelefon.TabIndex = 1;
            lblTelefon.Text = "Telefon:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(177, 167);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(81, 15);
            lblDateOfBirth.TabIndex = 2;
            lblDateOfBirth.Text = "Doğum Tarihi:";
            // 
            // lblDepartman
            // 
            lblDepartman.AutoSize = true;
            lblDepartman.Location = new Point(177, 206);
            lblDepartman.Name = "lblDepartman";
            lblDepartman.Size = new Size(69, 15);
            lblDepartman.TabIndex = 3;
            lblDepartman.Text = "Departman:";
            // 
            // lblMaas
            // 
            lblMaas.AutoSize = true;
            lblMaas.Location = new Point(177, 244);
            lblMaas.Name = "lblMaas";
            lblMaas.Size = new Size(38, 15);
            lblMaas.TabIndex = 4;
            lblMaas.Text = "Maaş:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(344, 85);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(344, 125);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 6;
            // 
            // txtDepartman
            // 
            txtDepartman.Location = new Point(344, 203);
            txtDepartman.Name = "txtDepartman";
            txtDepartman.Size = new Size(100, 23);
            txtDepartman.TabIndex = 7;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(344, 241);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(100, 23);
            txtMaas.TabIndex = 8;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(344, 161);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 23);
            dtpDOB.TabIndex = 9;
            // 
            // btnSerialize
            // 
            btnSerialize.Location = new Point(227, 326);
            btnSerialize.Name = "btnSerialize";
            btnSerialize.Size = new Size(75, 23);
            btnSerialize.TabIndex = 10;
            btnSerialize.Text = "Serileştir";
            btnSerialize.UseVisualStyleBackColor = true;
            btnSerialize.Click += btnSerialize_Click;
            // 
            // btnDeserialize
            // 
            btnDeserialize.Location = new Point(383, 326);
            btnDeserialize.Name = "btnDeserialize";
            btnDeserialize.Size = new Size(75, 23);
            btnDeserialize.TabIndex = 11;
            btnDeserialize.Text = "DeSerileştir";
            btnDeserialize.UseVisualStyleBackColor = true;
            btnDeserialize.Click += btnDeserialize_Click;
            // 
            // btnJsonSerialize
            // 
            btnJsonSerialize.Location = new Point(227, 372);
            btnJsonSerialize.Name = "btnJsonSerialize";
            btnJsonSerialize.Size = new Size(75, 50);
            btnJsonSerialize.TabIndex = 12;
            btnJsonSerialize.Text = "Json Serileştir";
            btnJsonSerialize.UseVisualStyleBackColor = true;
            btnJsonSerialize.Click += btnJsonSerialize_Click;
            // 
            // btnJsonDeserialize
            // 
            btnJsonDeserialize.Location = new Point(383, 372);
            btnJsonDeserialize.Name = "btnJsonDeserialize";
            btnJsonDeserialize.Size = new Size(75, 50);
            btnJsonDeserialize.TabIndex = 13;
            btnJsonDeserialize.Text = "Json DeSerileştir";
            btnJsonDeserialize.UseVisualStyleBackColor = true;
            btnJsonDeserialize.Click += btnJsonDeserialize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnJsonDeserialize);
            Controls.Add(btnJsonSerialize);
            Controls.Add(btnDeserialize);
            Controls.Add(btnSerialize);
            Controls.Add(dtpDOB);
            Controls.Add(txtMaas);
            Controls.Add(txtDepartman);
            Controls.Add(txtTelefon);
            Controls.Add(txtAd);
            Controls.Add(lblMaas);
            Controls.Add(lblDepartman);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblTelefon);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblTelefon;
        private Label lblDateOfBirth;
        private Label lblDepartman;
        private Label lblMaas;
        private TextBox txtAd;
        private TextBox txtTelefon;
        private TextBox txtDepartman;
        private TextBox txtMaas;
        private DateTimePicker dtpDOB;
        private Button btnSerialize;
        private Button btnDeserialize;
        private Button btnJsonSerialize;
        private Button btnJsonDeserialize;
    }
}
