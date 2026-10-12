namespace WinFormsApp4
{
    partial class BiletForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletForm));
            cmbFilmSec = new ComboBox();
            panelKoltuklar = new FlowLayoutPanel();
            label1 = new Label();
            lblSalon = new Label();
            lblSecilenler = new Label();
            lblUcret = new Label();
            btnSatisTamamla = new Button();
            btnGeri = new Button();
            cmbTarihSec = new ComboBox();
            cmbSaatSec = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbFilmSec
            // 
            cmbFilmSec.FormattingEnabled = true;
            cmbFilmSec.Location = new Point(579, 12);
            cmbFilmSec.Name = "cmbFilmSec";
            cmbFilmSec.Size = new Size(151, 28);
            cmbFilmSec.TabIndex = 0;
            cmbFilmSec.SelectedIndexChanged += cmbFilmSec_SelectedIndexChanged;
            // 
            // panelKoltuklar
            // 
            panelKoltuklar.Location = new Point(27, 12);
            panelKoltuklar.Margin = new Padding(5);
            panelKoltuklar.Name = "panelKoltuklar";
            panelKoltuklar.Padding = new Padding(5);
            panelKoltuklar.Size = new Size(395, 431);
            panelKoltuklar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(469, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 0;
            label1.Text = "Film Seçin";
            // 
            // lblSalon
            // 
            lblSalon.AutoSize = true;
            lblSalon.BackColor = Color.Transparent;
            lblSalon.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblSalon.ForeColor = SystemColors.ButtonHighlight;
            lblSalon.Location = new Point(469, 204);
            lblSalon.Name = "lblSalon";
            lblSalon.Size = new Size(51, 18);
            lblSalon.TabIndex = 1;
            lblSalon.Text = "Salon ";
            // 
            // lblSecilenler
            // 
            lblSecilenler.AutoSize = true;
            lblSecilenler.BackColor = Color.Transparent;
            lblSecilenler.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblSecilenler.ForeColor = SystemColors.ButtonHighlight;
            lblSecilenler.Location = new Point(469, 238);
            lblSecilenler.Name = "lblSecilenler";
            lblSecilenler.Size = new Size(131, 18);
            lblSecilenler.TabIndex = 3;
            lblSecilenler.Text = "Seçilen Koltuklar";
            // 
            // lblUcret
            // 
            lblUcret.AutoSize = true;
            lblUcret.BackColor = Color.Transparent;
            lblUcret.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblUcret.ForeColor = SystemColors.ButtonHighlight;
            lblUcret.Location = new Point(469, 271);
            lblUcret.Name = "lblUcret";
            lblUcret.Size = new Size(104, 18);
            lblUcret.TabIndex = 4;
            lblUcret.Text = "Toplam Ücret";
            // 
            // btnSatisTamamla
            // 
            btnSatisTamamla.Location = new Point(535, 314);
            btnSatisTamamla.Name = "btnSatisTamamla";
            btnSatisTamamla.Size = new Size(184, 29);
            btnSatisTamamla.TabIndex = 5;
            btnSatisTamamla.Text = "Bilet Satışını Tamamla";
            btnSatisTamamla.UseVisualStyleBackColor = true;
            btnSatisTamamla.Click += btnSatisTamamla_Click_1;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(594, 377);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 6;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // cmbTarihSec
            // 
            cmbTarihSec.FormattingEnabled = true;
            cmbTarihSec.Location = new Point(579, 62);
            cmbTarihSec.Name = "cmbTarihSec";
            cmbTarihSec.Size = new Size(151, 28);
            cmbTarihSec.TabIndex = 7;
            cmbTarihSec.SelectedIndexChanged += cmbTarihSec_SelectedIndexChanged;
            // 
            // cmbSaatSec
            // 
            cmbSaatSec.FormattingEnabled = true;
            cmbSaatSec.Location = new Point(579, 111);
            cmbSaatSec.Name = "cmbSaatSec";
            cmbSaatSec.Size = new Size(151, 28);
            cmbSaatSec.TabIndex = 8;
            cmbSaatSec.SelectedIndexChanged += cmbSaatSec_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(469, 119);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 9;
            label2.Text = "Saat Seçin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(466, 70);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 10;
            label3.Text = "Tarih Seçin";
            // 
            // BiletForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbSaatSec);
            Controls.Add(cmbTarihSec);
            Controls.Add(btnGeri);
            Controls.Add(btnSatisTamamla);
            Controls.Add(lblUcret);
            Controls.Add(lblSecilenler);
            Controls.Add(label1);
            Controls.Add(panelKoltuklar);
            Controls.Add(lblSalon);
            Controls.Add(cmbFilmSec);
            Name = "BiletForm";
            Text = "BiletForm";
            Load += BiletForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFilmSec;
        private ComboBox cmbSalonSec;
        private FlowLayoutPanel panelKoltuklar;
        private Label label1;
        private Label lblSalon;
        private Label lblSecilenler;
        private Label lblUcret;
        private Button btnSatisTamamla;
        private Button btnGeri;
        private ComboBox cmbTarihSec;
        private ComboBox cmbSaatSec;
        private Label label2;
        private Label label3;
    }
}