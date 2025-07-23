using _13_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_OOPOrnek1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GellAllCategories();
        }

        private void GellAllCategories()
        {
            cmbKategoriler.Items.AddRange(new string[] { "Gömlek", "Cep Telefonu" });
        }

        int secilen;
        Sepet sepetim = new Sepet();
        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (secilen == 0)
            {
                Gomlek g = new Gomlek()
                {
                    ProductName = txtUrunAdi.Text,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    UnitPrice = 5600
                };

                sepetim.UrunEkle(g);
            }
            else
            {

            }

            ListeyiGuncelle();
        }

        private void ListeyiGuncelle()
        {
            lstListe.Items.Clear();
            sepetim.UrunListesi.ForEach(x => lstListe.Items.Add(x));
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = cmbKategoriler.SelectedIndex;
        }
    }
}
