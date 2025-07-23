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
            //tutar hesaplanýrken eðer ;
            //Kurumsal fatura secili ile %20 kdvli tutar hesaplansýn
            //Bireysel fatura secili ile %18 kdvli tutar hesaplansýn

            //ürün adý, adet, birim fiyatý , tutar olarak sepete eklenecek
            //ekleme islemi yapýldýðýnda ayný zamanda arka planda bir dizide toplam tutarlarý tutalým.

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
            //0. satýr 
            urunListesi[0, 0] = "1";
            urunListesi[0, 1] = "VGA";
            //1. satýr
            urunListesi[1, 0] = "1";
            urunListesi[1, 1] = "RAM";
            //2. satýr
            urunListesi[2, 0] = "2";
            urunListesi[2, 1] = "KOLTUK";
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combodan herhangi bir þey seçildi ise kontrolü yaptýk:
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

            int satirBoyutu = urunListesi.GetLength(0); //3 satýr
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

                //Listbox'a eklemeleri yapalým:
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
                MessageBox.Show("Lütfen önce fatura tipini seçiniz.");
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
