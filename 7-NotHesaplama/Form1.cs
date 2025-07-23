namespace _7_NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Dictionary koleksiyon yap�s�
        //key , value mant��� i�e �al���r

        //key   : string
        //value : double

        Dictionary<string, double> ogrenciListesi = new Dictionary<string, double>();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //try catch
            //try : t�m islemler bu blokta yap�l�r
            //catch : herhangi bir hata olmas� durumunda bu blok �al���r. Burada exception nesnesi �zerinden message property'si ile hata mesaj� yakalan�r.
            //finally   : her iki durumda da bu b�l�m �al��acakt�r.

            try
            {
                string adSoyad = txtAdSoyad.Text;
                double vizeNotu = Convert.ToDouble(txtVize.Text);
                double finalNotu = Convert.ToDouble(txtFinal.Text);

                //ortalama hesapla
                double ortalama = OrtalamaHesapla(vizeNotu, finalNotu);

                ogrenciListesi[adSoyad] = ortalama;

                ListeyiGuncelle();
            }
            catch (Exception ex)
            {
                lblMesaj.Text = ex.Message;
            }
            finally
            {

            }
        }

        private void ListeyiGuncelle()
        {
            lstListe.Items.Clear();
            foreach (var item in ogrenciListesi)
            {
                lstListe.Items.Add($"{item.Key}-{item.Value}");
            }
        }

        private double OrtalamaHesapla(double vizeNotu, double finalNotu)
        {
            double ort = (vizeNotu * 0.40) + (finalNotu * 0.60);
            return ort;
        }
    }
}
