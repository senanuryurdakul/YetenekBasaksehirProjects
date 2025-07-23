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
    public partial class Ornek2 : Form
    {
        public Ornek2()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Ürün adı, adedi ve fiyatı form üzerinden girilecektir. Toplam tutar yüzde 20 kdv dahil olarak hesaplanarak label'a yazdırılacaktır.

            //... adlı ürün için verdiğiniz siparisin %20 kdv dahil toplam tutarı ... TL dir.

            string productName = txtUrunAdi.Text;
            int quantity = Convert.ToInt32(txtUrunAdedi.Text);
            double unitPrice = Convert.ToDouble(txtUrunFiyati.Text);

            double totalPrice = quantity * unitPrice * 1.20;

            lblMesaj.Text = $"{productName} adlı ürün için verdiğiniz siparisin %20 kdv dahil toplam tutarı {totalPrice} TL dir.";


        }
    }
}
