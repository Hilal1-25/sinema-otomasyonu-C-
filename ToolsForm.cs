using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class ToolsForm : Form
    {
        public ToolsForm()
        {
            InitializeComponent();
        }

        private void ToolsForm_Load(object sender, EventArgs e)
        {

        }

        private void film_Click(object sender, EventArgs e)
        {
            Form1 film = new Form1();
            film.Show();
            this.Hide();
        }

        

        private void bilet_Click(object sender, EventArgs e)
        {
            BiletForm bilet = new BiletForm();
            bilet.Show();
            this.Hide();
        }

        private void cıkıs_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close(); // Menüyü tamamen kapatır
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminForm adminSayfasi = new AdminForm();
            adminSayfasi.Show();
            this.Hide(); // Ana menüyü geçici olarak gizle
        }

        private void salon_Click_1(object sender, EventArgs e)
        {
            SalonForm salon = new SalonForm(); // (Henüz oluşturmadıysan eklemelisin)
            salon.Show();
            this.Hide();
        }
    }
}
