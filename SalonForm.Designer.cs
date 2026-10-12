namespace WinFormsApp4
{
    partial class SalonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalonForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSalonAd = new TextBox();
            txtSatir = new TextBox();
            txtSutun = new TextBox();
            btnSalonEkle = new Button();
            btnGeri = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(339, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 18);
            label1.TabIndex = 0;
            label1.Text = "Salon Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(339, 120);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 1;
            label2.Text = "Satır Sayısı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(339, 212);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 2;
            label3.Text = "Sütın Sayısı";
            // 
            // txtSalonAd
            // 
            txtSalonAd.Location = new Point(455, 25);
            txtSalonAd.Name = "txtSalonAd";
            txtSalonAd.Size = new Size(125, 27);
            txtSalonAd.TabIndex = 3;
            // 
            // txtSatir
            // 
            txtSatir.Location = new Point(455, 113);
            txtSatir.Name = "txtSatir";
            txtSatir.Size = new Size(125, 27);
            txtSatir.TabIndex = 4;
            // 
            // txtSutun
            // 
            txtSutun.Location = new Point(455, 205);
            txtSutun.Name = "txtSutun";
            txtSutun.Size = new Size(125, 27);
            txtSutun.TabIndex = 5;
            // 
            // btnSalonEkle
            // 
            btnSalonEkle.BackColor = Color.LightPink;
            btnSalonEkle.Location = new Point(339, 310);
            btnSalonEkle.Name = "btnSalonEkle";
            btnSalonEkle.Size = new Size(241, 29);
            btnSalonEkle.TabIndex = 6;
            btnSalonEkle.Text = "Salon Ekle";
            btnSalonEkle.UseVisualStyleBackColor = false;
            btnSalonEkle.Click += btnSalonEkle_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(415, 374);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 7;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // SalonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnGeri);
            Controls.Add(btnSalonEkle);
            Controls.Add(txtSutun);
            Controls.Add(txtSatir);
            Controls.Add(txtSalonAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "SalonForm";
            Text = "SalonForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSalonAd;
        private TextBox txtSatir;
        private TextBox txtSutun;
        private Button btnSalonEkle;
        private Button btnGeri;
    }
}