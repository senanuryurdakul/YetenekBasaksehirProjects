using _13_OOPOrnek1.Entities;

namespace _13_OOPOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region GenericList
            //Generic List
            //List<string> list = new List<string>();
            //list.Add("aailea");
            //list.Remove("aeai2");
            //list.RemoveAt(1);

            //List<int> list2 = new List<int>();
            //list2.Add(323);
            #endregion
            GetAllCategories();
        }

        private void GetAllCategories()
        {
            cmbKategoriler.Items.AddRange(new string[] { "Gömlek", "Cep Telefonu" });
        }

        List<Urun> urunListesi = new List<Urun>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Gomlek g = new Gomlek()
            {
                ProductName = "Lacoste Slim Fit",
                UnitPrice = 5000,
                Quantity = 5,
                Size = "XL"
            };

            urunListesi.Add(g);

            CepTelefonu cp = new CepTelefonu()
            {
                ProductName = "Iphone 16 Pro Max",
                Quantity = 54,
                UnitPrice = 120000,
                BatteryLife = 4,
                CpuModel = "Intel Core",
                RamCapacity = 64
            };

            urunListesi.Add(cp);

            foreach (var item in urunListesi)
            {
                lstListe.Items.Add($"{item.ProductName}-{item.UnitPrice}");
                Gomlek gomlek1 = item as Gomlek;
                //CepTelefonu cp1 = (CepTelefonu)item;
            }
        }

        private void nmrAdet_ValueChanged(object sender, EventArgs e)
        {

        }
        List<Urun> sepet = new List<Urun>();
        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (secilen == 0)
            {
                //gomlek
                Gomlek g = new Gomlek()
                {
                    ProductName = txtUrunAdi.Text,
                    UnitPrice = 5000,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    Size = "XL"
                };

                g.UnitPrice = g.KdvHesapla();
                sepet.Add(g);
            }
            else
            {
                //cep telefonu
                CepTelefonu cp = new CepTelefonu()
                {
                    ProductName = txtUrunAdi.Text,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    UnitPrice = 5000,
                    BatteryLife = 4,
                    CpuModel = "Intel Core",
                    RamCapacity = 64
                };

                cp.UnitPrice = cp.KdvHesapla();
                sepet.Add(cp);
            }

            UrunleriListele();
        }

        private void UrunleriListele()
        {
            lstListe.Items.Clear();
            sepet.ForEach(x => lstListe.Items.Add($"{x.ProductName}-{x.Quantity}-{x.UnitPrice}"));

            //sepet.ForEach(x => lstListe.Items.Add(x));
        }

        int secilen;
        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = cmbKategoriler.SelectedIndex;
        }
    }
}
