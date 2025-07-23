using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Degiskenler
{
    public partial class Ornek : Form
    {
        public Ornek()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //get
            string urunAdi = txtUrunAdi.Text;
            //string urunAdedi = txtUrunAdedi.Text;
            string urunFiyati = txtUrunFiyati.Text;

            //Tür Dönüşümleri
            //string to int
            //int quantity = Convert.ToInt32(urunAdedi);
            int quantity = Convert.ToInt32(txtUrunAdedi.Text);
            double a = quantity * 1.20;
            ////set
            //txtUrunAdi.Text = "HP Laptop";

            //Double to string
            //MessageBox.Show(a.ToString());

            //lblMesaj.Text = ".... adlı ürünün yeni fiyatı ... dır";

            //lblMesaj.Text = urunAdi + " adlı ürünü yeni fiyatı " + urunFiyati;
            lblMesaj.Text = $"{urunAdi} adlı ürünün yeni fiyatı {urunFiyati}";
        }
    }
}
