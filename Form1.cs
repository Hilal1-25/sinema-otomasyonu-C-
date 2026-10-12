using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnListele_Click(object sender, EventArgs e)
        {
            // Veritabaný yolun (Kendi bilgisayarýna göre kontrol etmeyi unutma)
            string yol = @"Data Source=C:\Users\Asus\Desktop\sinema.db;Version=3;";

            using (SQLiteConnection baglanti = new SQLiteConnection(yol))
            {
                try
                {
                    baglanti.Open();
                    listFilmler.Items.Clear(); // ListBox'ý her aramada temizler

                    // 1. DURUM: Eðer Film Adý kutusu doluysa, o filmin TÜM detaylarýný getir
                    if (!string.IsNullOrEmpty(txtFilmAd.Text))
                    {
                        string sorgu = "SELECT * FROM Filmler WHERE FilmAd = @p1";
                        SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@p1", txtFilmAd.Text);

                        SQLiteDataReader dr = komut.ExecuteReader();
                        if (dr.Read())
                        {
                            // Yeni isimlerle kutularý dolduruyoruz
                            txtFilmTur.Text = dr["FilmTur"].ToString();
                            txtFilmSure.Text = dr["FilmSure"].ToString();
                            txtTarih.Text = dr["FilmTarih"].ToString();
                            txtSaat.Text = dr["FilmSaat"].ToString();
                            txtFilmSalonu.Text = dr["FilmSalon"].ToString();

                            // Görsel olarak listeye de ekleyelim
                            listFilmler.Items.Add("Bulundu: " + dr["FilmAd"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Aradýðýnýz isimde bir film bulunamadý.");
                        }
                    }
                    // 2. DURUM: Film Adý boþsa; Tür, Tarih veya Saat kriterlerine göre ARA
                    else if (!string.IsNullOrEmpty(txtFilmTur.Text) || !string.IsNullOrEmpty(txtTarih.Text) || !string.IsNullOrEmpty(txtSaat.Text))
                    {
                        // LIKE ve % kullanýmý sayesinde 'Dram' yazýnca 'Dram / Romantik' olanlarý da yakalarýz
                        string sorgu = "SELECT FilmAd, FilmSaat, FilmSalon FROM Filmler WHERE FilmTur LIKE @p1 AND FilmTarih LIKE @p2 AND FilmSaat LIKE @p3";
                        SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);

                        komut.Parameters.AddWithValue("@p1", "%" + txtFilmTur.Text + "%");
                        komut.Parameters.AddWithValue("@p2", "%" + txtTarih.Text + "%");
                        komut.Parameters.AddWithValue("@p3", "%" + txtSaat.Text + "%");

                        SQLiteDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            // ListBox'ta Film Adý - Saat - Salon bilgisini yan yana gösterir
                            listFilmler.Items.Add(dr["FilmAd"].ToString() + " | " + dr["FilmSaat"].ToString() + " | " + dr["FilmSalon"].ToString());
                        }

                        if (listFilmler.Items.Count == 0)
                        {
                            MessageBox.Show("Kriterlere uygun seans bulunamadý.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen arama yapmak için en az bir kutuyu doldurun!");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Veritabaný Hatasý: " + hata.Message);
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            // 1. Ana menü formunu (ToolsForm) belleðe çaðýrýyoruz
            ToolsForm anaMenu = new ToolsForm();

            // 2. Ana menü ekranýný kullanýcýya gösteriyoruz
            anaMenu.Show();

            // 3. Þu an açýk olan bu formu (Form1) kapatýyoruz
            this.Close();
        }
    }
}

