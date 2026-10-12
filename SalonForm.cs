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
    public partial class SalonForm : Form
    {
        public SalonForm()
        {
            InitializeComponent();
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {

            {
                SQLiteConnection baglanti = new SQLiteConnection(@"Data Source=C:\Users\Asus\Desktop\sinema.db;Version=3;");
                try
                {
                    baglanti.Open();
                    // Veritabanındaki Salonlar tablosuna kayıt
                    string sorgu = "INSERT INTO Salonlar (SalonAd, SatirSayi, SutunSayi) VALUES (@p1, @p2, @p3)";
                    SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", txtSalonAd.Text);
                    komut.Parameters.AddWithValue("@p2", Convert.ToInt32(txtSatir.Text));
                    komut.Parameters.AddWithValue("@p3", Convert.ToInt32(txtSutun.Text));

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Salon başarıyla oluşturuldu!");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata: " + hata.Message);
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            // Ana menüyü (ToolsForm) tekrar oluşturuyoruz
            ToolsForm anaMenu = new ToolsForm();

            // Ana menüyü göster
            anaMenu.Show();

            // Şu anki formu (Bilet veya Salon formu) tamamen kapat
            this.Close();
        }
    }
}
