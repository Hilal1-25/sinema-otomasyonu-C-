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
    public partial class BiletForm : Form
    {
        int toplamUcret = 0;
        List<string> secilenKoltuklar = new List<string>();
        public BiletForm()
        {
            InitializeComponent();
        }

      
        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button basilanKoltuk = (Button)sender;

            // Eğer koltuk zaten seçiliyse iptal et (Yeşile döndür)
            if (basilanKoltuk.BackColor != System.Drawing.Color.LightGreen)
            {
                basilanKoltuk.BackColor = System.Drawing.Color.LightGreen;
                secilenKoltuklar.RemoveAll(x => x.Contains(basilanKoltuk.Text));
                toplamUcret -= 100;
                lblUcret.Text = "Toplam Ücret: " + toplamUcret + " TL";
                lblSecilenler.Text = "Seçilenler: " + string.Join(", ", secilenKoltuklar);
                return;
            }

            // 1. SORU: Cinsiyet Seçimi
            DialogResult cinsiyet = MessageBox.Show("Cinsiyet Erkek mi? \n(Evet: Erkek/Mavi, Hayır: Kadın/Pembe)",
                "Cinsiyet Seçimi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cinsiyet == DialogResult.Cancel) return; // İptal edilirse hiçbir şey yapma

            // 2. ADIM: İsim Sayfasına Git
            using (IsımForm isimFormu = new IsımForm())
            {
                if (isimFormu.ShowDialog() == DialogResult.OK) // İsim girilip 'Tamam'a basılırsa
                {
                    string musteri = isimFormu.GelenIsim;

                    // 3. ADIM: Renk ve Liste Güncelleme
                    if (cinsiyet == DialogResult.Yes)
                        basilanKoltuk.BackColor = System.Drawing.Color.LightBlue; // Erkek
                    else
                        basilanKoltuk.BackColor = System.Drawing.Color.Pink; // Kadın

                    // Listeye ekle: "Koltuk 5 - Ali Yılmaz" gibi
                    secilenKoltuklar.Add(basilanKoltuk.Text + " - " + musteri);
                    toplamUcret += 100;

                    // Alt taraftaki yazıları güncelle
                    lblSecilenler.Text = "Seçilenler: " + string.Join(", ", secilenKoltuklar);
                    lblUcret.Text = "Toplam Ücret: " + toplamUcret + " TL";
                }
            }
        }


        private void BiletForm_Load(object sender, EventArgs e)
        {
            try
            {
                string yol = @"Data Source=C:\Users\Asus\Desktop\sinema.db;Version=3;";
                using (SQLiteConnection baglanti = new SQLiteConnection(yol))
                {
                    baglanti.Open();

                    // SADECE FİLMLERİ DOLDUR
                    cmbFilmSec.Items.Clear();
                    SQLiteCommand komut = new SQLiteCommand("SELECT FilmAd FROM Filmler", baglanti);
                    SQLiteDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        cmbFilmSec.Items.Add(dr["FilmAd"].ToString());
                    }
                    // SALONLARI BURADA DOLDURMAYA ÇALIŞAN KOD VARSA SİL!
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme hatası: " + ex.Message);
            }
        }
        private void btnSatisTamamla_Click_1(object sender, EventArgs e)
        {


            if (secilenKoltuklar.Count == 0)
            {
                MessageBox.Show("Lütfen önce en az bir koltuk seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen koltukları bir mesajla göster
            string mesaj = "Bilet Satışı Başarıyla Tamamlandı!\n\n" +
                           "Film: " + cmbFilmSec.Text + "\n" +
                           "Salon: " + lblSalon.Text + "\n" +
                           "Koltuklar: " + string.Join(", ", secilenKoltuklar) + "\n" +
                           "Ödenen Tutar: " + toplamUcret + " TL";

            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Satış bittiği için ana menüye (ToolsForm) geri dönelim
            ToolsForm anaMenu = new ToolsForm();
            anaMenu.Show();
            this.Close(); // Bilet formunu kapat
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

        private void cmbFilmSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yol = @"Data Source=C:\Users\Asus\Desktop\sinema.db;Version=3;";
            using (SQLiteConnection baglanti = new SQLiteConnection(yol))
            {
                baglanti.Open();
                cmbTarihSec.Items.Clear();
                cmbSaatSec.Items.Clear(); // Öncekileri temizle

                // Seçilen filme ait benzersiz (DISTINCT) tarihleri getir
                string sorgu = "SELECT DISTINCT FilmTarih FROM Filmler WHERE FilmAd = @p1";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", cmbFilmSec.Text);

                SQLiteDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmbTarihSec.Items.Add(dr["FilmTarih"].ToString());
                }
            }
        }

        private void cmbTarihSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yol = @"Data Source=C:\Users\Asus\Desktop\sinema.db;Version=3;";
            using (SQLiteConnection baglanti = new SQLiteConnection(yol))
            {
                baglanti.Open();
                cmbSaatSec.Items.Clear();

                // Seçilen film ve tarihe ait saatleri getir
                string sorgu = "SELECT FilmSaat FROM Filmler WHERE FilmAd = @p1 AND FilmTarih = @p2";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", cmbFilmSec.Text);
                komut.Parameters.AddWithValue("@p2", cmbTarihSec.Text);

                SQLiteDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmbSaatSec.Items.Add(dr["FilmSaat"].ToString());
                }
            }
        }

        private void cmbSaatSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yol = @"Data Source=C:\Users\Asus\Desktop\sinema.db;Version=3;";
            using (SQLiteConnection baglanti = new SQLiteConnection(yol))
            {
                baglanti.Open();
                // 1. Önce seansın salon adını bul
                string sorgu = "SELECT FilmSalon FROM Filmler WHERE FilmAd = @p1 AND FilmTarih = @p2 AND FilmSaat = @p3";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", cmbFilmSec.Text);
                komut.Parameters.AddWithValue("@p2", cmbTarihSec.Text);
                komut.Parameters.AddWithValue("@p3", cmbSaatSec.Text);

                object salonAdi = komut.ExecuteScalar();
                if (salonAdi != null)
                {
                    lblSalon.Text = "Salon: " + salonAdi.ToString();
                    // 2. Koltukları çizme komutunu veriyoruz
                    KoltuklariGetir(salonAdi.ToString());
                }
            }
        }
        private void KoltuklariGetir(string salonIsmi)
        {
            // 1. Önce paneli temizle ki eski koltuklar yeni seansla karışmasın
            panelKoltuklar.Controls.Clear();

            string yol = @"Data Source=C:\Users\Asus\Desktop\sinema.db;Version=3;";
            using (SQLiteConnection baglanti = new SQLiteConnection(yol))
            {
                try
                {
                    baglanti.Open();
                    // 2. Salonlar tablosundan seçilen salonun kapasitesini çekiyoruz
                    string sorgu = "SELECT SatirSayisi, SutunSayisi FROM Salonlar WHERE SalonAd = @p1";
                    SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", salonIsmi);

                    SQLiteDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        int satir = Convert.ToInt32(dr["SatirSayisi"]);
                        int sutun = Convert.ToInt32(dr["SutunSayisi"]);

                        int sayac = 1;
                        // 3. İç içe döngü ile koltuk butonlarını oluşturuyoruz
                        for (int i = 0; i < satir; i++) // Satırlar
                        {
                            for (int j = 0; j < sutun; j++) // Sütunlar
                            {
                                Button btn = new Button();
                                btn.Size = new Size(45, 45); // Butonun büyüklüğü

                                // Butonların panel üzerindeki koordinatları (x, y)
                                // Aralarında 5'er piksel boşluk bırakıyoruz
                                btn.Location = new Point(j * 50 + 20, i * 50 + 20);

                                btn.Text = sayac.ToString();
                                btn.BackColor = Color.LightGreen; // Başlangıçta hepsi yeşil (boş)
                                btn.Name = "btnKoltuk_" + sayac; // Butona özel isim

                                // 4. DAHA ÖNCE YAZDIĞIMIZ TIKLAMA OLAYINI BAĞLIYORUZ
                                // (Hani şu cinsiyet ve isim sorduğumuz meşhur kod)
                                btn.Click += Koltuk_Click;

                                // 5. Oluşturulan butonu panelKoltuklar isimli panele ekle
                                panelKoltuklar.Controls.Add(btn);

                                sayac++;
                            }
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Koltuklar çizilirken hata oluştu: " + hata.Message);
                }
            }
        }

       
    }
}

