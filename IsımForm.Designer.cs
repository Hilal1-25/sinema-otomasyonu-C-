namespace WinFormsApp4
{
    partial class IsımForm
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
            btnTamam = new Button();
            label1 = new Label();
            txtAdSoyad = new TextBox();
            SuspendLayout();
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(376, 201);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(123, 29);
            btnTamam.TabIndex = 0;
            btnTamam.Text = "Kaydet ve Dön";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 78);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 1;
            label1.Text = "Müşteri Adı Soyadı";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(448, 71);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 3;
            // 
            // IsımForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAdSoyad);
            Controls.Add(label1);
            Controls.Add(btnTamam);
            Name = "IsımForm";
            Text = "IsımForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTamam;
        private Label label1;
        private TextBox txtAdSoyad;
    }
}