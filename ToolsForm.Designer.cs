namespace WinFormsApp4
{
    partial class ToolsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsForm));
            film = new Button();
            bilet = new Button();
            cıkıs = new Button();
            btnAdminPanel = new Button();
            salon = new Button();
            SuspendLayout();
            // 
            // film
            // 
            film.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            film.BackColor = Color.Transparent;
            film.BackgroundImageLayout = ImageLayout.Zoom;
            film.Cursor = Cursors.SizeAll;
            film.FlatAppearance.BorderSize = 0;
            film.FlatStyle = FlatStyle.Flat;
            film.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            film.ForeColor = SystemColors.ControlText;
            film.Image = Properties.Resources.clapperboardfilmm;
            film.ImageAlign = ContentAlignment.TopCenter;
            film.Location = new Point(428, 104);
            film.Name = "film";
            film.Size = new Size(195, 74);
            film.TabIndex = 0;
            film.TabStop = false;
            film.Text = "Film Seç";
            film.TextAlign = ContentAlignment.BottomCenter;
            film.UseVisualStyleBackColor = false;
            film.Click += film_Click;
            // 
            // bilet
            // 
            bilet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bilet.BackColor = Color.Transparent;
            bilet.BackgroundImageLayout = ImageLayout.Zoom;
            bilet.Cursor = Cursors.SizeAll;
            bilet.FlatAppearance.BorderSize = 0;
            bilet.FlatStyle = FlatStyle.Flat;
            bilet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bilet.ForeColor = Color.Black;
            bilet.Image = Properties.Resources.bilet;
            bilet.ImageAlign = ContentAlignment.TopCenter;
            bilet.Location = new Point(175, 114);
            bilet.Name = "bilet";
            bilet.Size = new Size(195, 74);
            bilet.TabIndex = 3;
            bilet.TabStop = false;
            bilet.Text = "Bilet Seç";
            bilet.TextAlign = ContentAlignment.BottomCenter;
            bilet.UseVisualStyleBackColor = false;
            bilet.Click += bilet_Click;
            // 
            // cıkıs
            // 
            cıkıs.BackColor = Color.Salmon;
            cıkıs.FlatStyle = FlatStyle.Flat;
            cıkıs.Location = new Point(327, 339);
            cıkıs.Name = "cıkıs";
            cıkıs.Size = new Size(173, 33);
            cıkıs.TabIndex = 5;
            cıkıs.Text = "Çıkış";
            cıkıs.UseVisualStyleBackColor = false;
            cıkıs.Click += cıkıs_Click;
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.BackColor = Color.Transparent;
            btnAdminPanel.BackgroundImageLayout = ImageLayout.None;
            btnAdminPanel.FlatAppearance.BorderSize = 0;
            btnAdminPanel.FlatStyle = FlatStyle.Flat;
            btnAdminPanel.ForeColor = SystemColors.ActiveCaptionText;
            btnAdminPanel.Image = Properties.Resources.user1;
            btnAdminPanel.ImageAlign = ContentAlignment.TopCenter;
            btnAdminPanel.Location = new Point(190, 223);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(203, 74);
            btnAdminPanel.TabIndex = 6;
            btnAdminPanel.Text = "Yeni Kullanıcı Gir";
            btnAdminPanel.TextAlign = ContentAlignment.BottomCenter;
            btnAdminPanel.UseVisualStyleBackColor = false;
            btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // salon
            // 
            salon.BackColor = Color.Transparent;
            salon.BackgroundImageLayout = ImageLayout.Zoom;
            salon.FlatAppearance.BorderSize = 0;
            salon.FlatStyle = FlatStyle.Flat;
            salon.Image = Properties.Resources.theater__1_;
            salon.ImageAlign = ContentAlignment.TopCenter;
            salon.Location = new Point(387, 223);
            salon.Name = "salon";
            salon.Size = new Size(278, 74);
            salon.TabIndex = 7;
            salon.Text = "Salon Gir";
            salon.TextAlign = ContentAlignment.BottomCenter;
            salon.UseVisualStyleBackColor = false;
            salon.Click += salon_Click_1;
            // 
            // ToolsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(791, 526);
            Controls.Add(salon);
            Controls.Add(btnAdminPanel);
            Controls.Add(cıkıs);
            Controls.Add(bilet);
            Controls.Add(film);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "ToolsForm";
            Text = "ToolsForm";
            Load += ToolsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button film;
        private Button bilet;
        private Button cıkıs;
        private Button btnAdminPanel;
        private Button salon;
    }
}