using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnKaydetVeDevam_Click(object sender, EventArgs e)
        {
            string yol = @"Data Source=C:\Users\Asus\Desktop\sinema.db;Version=3;";

            // SQLiteConnection.ClearAllPools() komutu, tüm açık bağlantıları zorla kapatır
            SQLiteConnection.ClearAllPools();

            using (SQLiteConnection baglanti = new SQLiteConnection(yol))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO Admin (AdminIsim, AdminSifre) VALUES (@p1, @p2)";

                    using (SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@p1", txtAdminIsim.Text);
                        komut.Parameters.AddWithValue("@p2", txtAdminSifre.Text);

                        komut.ExecuteNonQuery();
                    }

                    // İşlem biter bitmez bağlantıyı kapatıyoruz
                    baglanti.Close();

                    MessageBox.Show("Admin başarıyla kaydedildi!");

                    ToolsForm anaMenu = new ToolsForm();
                    anaMenu.Show();
                    this.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata: " + hata.Message);
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            ToolsForm anaMenu = new ToolsForm();
            anaMenu.Show();
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
