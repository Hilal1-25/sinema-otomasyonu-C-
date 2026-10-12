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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void login_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısı (Masaüstündeki dosyana göre)
            SQLiteConnection baglanti = new SQLiteConnection(@"Data Source=C:\Users\Asus\Desktop\sinema.db;Version=3;");

            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM Admin WHERE AdminIsim=@p1 AND AdminSifre=@p2";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtkullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                SQLiteDataReader dr = komut.ExecuteReader();

                if (dr.Read()) // Eğer veritabanında böyle birisi bulunduysa
                {
                    MessageBox.Show("Giriş Başarılı! Hoş geldiniz.");

                    // Giriş başarılı olunca senin o eski formun (Film ekranın) açılsın
                    ToolsForm anaMenu = new ToolsForm();
                    anaMenu.Show();
                    //Form1 filmFormu = new Form1();
                    //filmFormu.Show();

                    this.Hide(); // Giriş ekranını gizle
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Sistemsel bir hata oluştu: " + hata.Message);
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

