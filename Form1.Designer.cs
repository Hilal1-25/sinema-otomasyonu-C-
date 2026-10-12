namespace WinFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnListele = new Button();
            txtFilmAd = new TextBox();
            txtFilmTur = new TextBox();
            txtFilmSure = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGeri = new Button();
            listFilmler = new ListBox();
            txtFilmSalonu = new TextBox();
            txtSaat = new TextBox();
            txtTarih = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnListele
            // 
            btnListele.Location = new Point(667, 397);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 0;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // txtFilmAd
            // 
            txtFilmAd.Location = new Point(620, 27);
            txtFilmAd.Name = "txtFilmAd";
            txtFilmAd.Size = new Size(125, 27);
            txtFilmAd.TabIndex = 1;
            // 
            // txtFilmTur
            // 
            txtFilmTur.Location = new Point(620, 92);
            txtFilmTur.Name = "txtFilmTur";
            txtFilmTur.Size = new Size(125, 27);
            txtFilmTur.TabIndex = 2;
            // 
            // txtFilmSure
            // 
            txtFilmSure.Location = new Point(620, 154);
            txtFilmSure.Name = "txtFilmSure";
            txtFilmSure.Size = new Size(125, 27);
            txtFilmSure.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(474, 36);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 5;
            label1.Text = "Film Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(474, 101);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 6;
            label2.Text = "Film Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(474, 163);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 7;
            label3.Text = "Film Süresi";
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(474, 397);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 8;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // listFilmler
            // 
            listFilmler.BackColor = Color.Pink;
            listFilmler.FormattingEnabled = true;
            listFilmler.Location = new Point(94, 133);
            listFilmler.Name = "listFilmler";
            listFilmler.Size = new Size(176, 224);
            listFilmler.TabIndex = 9;
            // 
            // txtFilmSalonu
            // 
            txtFilmSalonu.Location = new Point(620, 317);
            txtFilmSalonu.Name = "txtFilmSalonu";
            txtFilmSalonu.Size = new Size(125, 27);
            txtFilmSalonu.TabIndex = 10;
            // 
            // txtSaat
            // 
            txtSaat.Location = new Point(620, 268);
            txtSaat.Name = "txtSaat";
            txtSaat.Size = new Size(125, 27);
            txtSaat.TabIndex = 11;
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(620, 211);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(125, 27);
            txtTarih.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(474, 220);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 13;
            label4.Text = "Film Tarihi ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(474, 277);
            label5.Name = "label5";
            label5.Size = new Size(80, 18);
            label5.TabIndex = 14;
            label5.Text = "Film Saati";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(474, 326);
            label6.Name = "label6";
            label6.Size = new Size(122, 18);
            label6.TabIndex = 15;
            label6.Text = "Salon Numarası";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTarih);
            Controls.Add(txtSaat);
            Controls.Add(txtFilmSalonu);
            Controls.Add(listFilmler);
            Controls.Add(btnGeri);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFilmSure);
            Controls.Add(txtFilmTur);
            Controls.Add(txtFilmAd);
            Controls.Add(btnListele);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListele;
        private TextBox txtFilmAd;
        private TextBox txtFilmTur;
        private TextBox txtFilmSure;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGeri;
        private ListBox listFilmler;
        private TextBox txtFilmSalonu;
        private TextBox txtSaat;
        private TextBox txtTarih;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
