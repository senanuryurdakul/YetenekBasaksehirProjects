namespace _8_UrunSiparisFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] urunListesi = new string[3, 2];
        private void Form1_Load(object sender, EventArgs e)
        {
            //tutar hesaplan�rken e�er ;
            //Kurumsal fatura secili ile %20 kdvli tutar hesaplans�n
            //Bireysel fatura secili ile %18 kdvli tutar hesaplans�n

            //�r�n ad�, adet, birim fiyat� , tutar olarak sepete eklenecek
            //ekleme islemi yap�ld���nda ayn� zamanda arka planda bir dizide toplam tutarlar� tutal�m.

            UrunleriHazirla();
            //ComboboxaVerileriGetirGetNames();
            ComboboxaVerileriGetirGetValues();

        }

        private void ComboboxaVerileriGetirGetValues()
        {
            //byte[] dizi = (byte[])Enum.GetValues(typeof(Kategoriler));

            Array dizi = Enum.GetValues(typeof(Kategoriler));

            foreach (var item in dizi)
            {
                cmbKategori.Items.Add(item);
            }
        }

        private void ComboboxaVerileriGetirGetNames()
        {
            string[] tumKategoriler = Enum.GetNames(typeof(Kategoriler));

            foreach (var item in tumKategoriler)
            {
                cmbKategori.Items.Add(item);
            }
        }

        private void UrunleriHazirla()
        {
            //0. sat�r 
            urunListesi[0, 0] = "1";
            urunListesi[0, 1] = "VGA";
            //1. sat�r
            urunListesi[1, 0] = "1";
            urunListesi[1, 1] = "RAM";
            //2. sat�r
            urunListesi[2, 0] = "2";
            urunListesi[2, 1] = "KOLTUK";
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combodan herhangi bir �ey se�ildi ise kontrol� yapt�k:
            if (cmbKategori.SelectedIndex != -1)
            {
                //string secilen=cmbKategori.SelectedItem.ToString();
                byte secilenID = (byte)cmbKategori.SelectedItem;

                UrunleriListeyeDoldur(secilenID);
            }
        }

        private void UrunleriListeyeDoldur(byte secilenID)
        {
            lstListe.Items.Clear();

            int satirBoyutu = urunListesi.GetLength(0); //3 sat�r
            int sutunBoyutu = urunListesi.GetLength(1); //2 sutun

            for (int i = 0; i < satirBoyutu; i++)
            {
                if (urunListesi[i, 0] == secilenID.ToString())
                {
                    lstListe.Items.Add(urunListesi[i, 1]);
                }
            }
        }
        decimal sonuc;
        private void txtBirimFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstListe.SelectedIndex != -1 && nmrAdet.Value != 0 && !string.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    sonuc = nmrAdet.Value * decimal.Parse(txtBirimFiyat.Text);
                    txtToplamTutar.Text = sonuc.ToString();
                }
            }
        }
        decimal kdvliTutar;
        int tutarIndex = 0;
        decimal[] tutarDizisi = new decimal[1];
        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (RadioButtonlardanEnAzBiriSecilimi())
            {
                //hangi radiobutton secili:

                //TERNARY IF
                bool hangiFatura = rdKurumsal.Checked ? true : false;

                if (hangiFatura)
                {
                    //kurumsal
                    kdvliTutar = sonuc * 1.20m;
                }
                else
                {
                    //bireysel
                    kdvliTutar = sonuc * 1.18m;
                }

                //Listbox'a eklemeleri yapal�m:
                lstSepet.Items.Add(
                    $"{lstListe.SelectedItem.ToString()} - {nmrAdet.Value} - {txtBirimFiyat.Text} - {kdvliTutar}"
                    );
                tutarDizisi[tutarIndex] = kdvliTutar;
                tutarIndex++;

                Array.Resize(ref tutarDizisi, tutarDizisi.Length + 1);

                lblSepetToplami.Text = ToplamGuncelle().ToString();
            }
            else
            {
                MessageBox.Show("L�tfen �nce fatura tipini se�iniz.");
            }


        }

        private decimal ToplamGuncelle()
        {
            decimal toplam = 0;
            foreach (var item in tutarDizisi)
            {
                toplam += item;
            }
            return toplam;
        }

        private bool RadioButtonlardanEnAzBiriSecilimi()
        {
            bool durum = false;

            foreach (var item in grpFaturaTipleri.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton radio = item as RadioButton;
                    if (radio.Checked)
                    {
                        durum = true;
                    }
                }
            }
            return durum;
        }

        private void txtBirimFiyat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
