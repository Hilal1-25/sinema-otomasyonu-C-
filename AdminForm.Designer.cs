9namespace WinFormsApp4
{
    partial class AdminForm
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
            txtAdminIsim = new TextBox();
            txtAdminSifre = new TextBox();
            btnKaydetVeDevam = new Button();
            label1 = new Label();
            label2 = new Label();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // txtAdminIsim
            // 
            txtAdminIsim.Location = new Point(393, 44);
            txtAdminIsim.Name = "txtAdminIsim";
            txtAdminIsim.Size = new Size(153, 27);
            txtAdminIsim.TabIndex = 0;
            // 
            // txtAdminSifre
            // 
            txtAdminSifre.Location = new Point(393, 140);
            txtAdminSifre.Name = "txtAdminSifre";
            txtAdminSifre.Size = new Size(153, 27);
            txtAdminSifre.TabIndex = 1;
            // 
            // btnKaydetVeDevam
            // 
            btnKaydetVeDevam.BackColor = SystemColors.ButtonFace;
            btnKaydetVeDevam.Location = new Point(301, 290);
            btnKaydetVeDevam.Name = "btnKaydetVeDevam";
            btnKaydetVeDevam.Size = new Size(166, 29);
            btnKaydetVeDevam.TabIndex = 2;
            btnKaydetVeDevam.Text = "Kaydet ve Devam Et";
            btnKaydetVeDevam.UseVisualStyleBackColor = false;
            btnKaydetVeDevam.Click += btnKaydetVeDevam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 51);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 147);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(345, 365);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(94, 29);
            btnIptal.TabIndex = 5;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIptal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydetVeDevam);
            Controls.Add(txtAdminSifre);
            Controls.Add(txtAdminIsim);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdminIsim;
        private TextBox txtAdminSifre;
        private Button btnKaydetVeDevam;
        private Label label1;
        private Label label2;
        private Button btnIptal;
    }
}