namespace WinFormsApp4
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            txtkullaniciAd = new TextBox();
            txtSifre = new TextBox();
            login = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(306, 286);
            label1.Name = "label1";
            label1.Size = new Size(99, 18);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(306, 338);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // txtkullaniciAd
            // 
            txtkullaniciAd.Location = new Point(457, 286);
            txtkullaniciAd.Name = "txtkullaniciAd";
            txtkullaniciAd.Size = new Size(169, 27);
            txtkullaniciAd.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(457, 331);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(169, 27);
            txtSifre.TabIndex = 3;
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // login
            // 
            login.Location = new Point(441, 394);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 4;
            login.Text = "Giriş";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(417, 127);
            button2.Name = "button2";
            button2.Size = new Size(118, 84);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(login);
            Controls.Add(txtSifre);
            Controls.Add(txtkullaniciAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtkullaniciAd;
        private TextBox txtSifre;
        private Button login;
        private Button button2;
    }
}