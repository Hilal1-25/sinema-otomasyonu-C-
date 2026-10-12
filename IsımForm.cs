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
    public partial class IsımForm : Form
    {
        public IsımForm()
        {
            InitializeComponent();
        }

        public string GelenIsim { get; set; } // İsmi diğer forma taşımak için

        private void btnTamam_Click(object sender, EventArgs e)
        {
            GelenIsim = txtAdSoyad.Text;
            this.DialogResult = DialogResult.OK; // Her şey yolunda mesajı
            this.Close(); // Bizi otomatik bilet formuna geri atar
        }
    }
}
