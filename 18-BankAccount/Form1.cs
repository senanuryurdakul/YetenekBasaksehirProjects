using _18_BankAccount.Entities;

namespace _18_BankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Hesap A��l�� ��lemi
            Otomatik olarak bir hesap numaras� olu�turulmal�d�r.
            Hesap a�arken mutlaka hesap sahibinin ad� soyad� ve ilk bakiye girilmelidir.

            Hesaptan Para �ekebilmeliyiz
            Hesapta para yoksa para �ekme islemi yap�lamas�n.

            Hesaba Para Yat�rabilmeliyiz
            Para yat�r�rken 0 dan b�y�k bir de�er olmas� sa�lanmal�d�r.

            1-InterestEarningAccount (Faiz Getiri Hesab�)
            E�er mevcut bakiye 500 dolardan fazla ise her ay sonu %5 faiz getirisi sa�lar.

            2-LineOfCreditAccount (Kredi Limit Hesab�)
            ???Eksi bakiyeye d��ebilir. Ancak eksi bakiye s�z konusu ise her ay sonu %7 faiz gideri uygulanacakt�r.

            3-GiftCardAccount (Hediye Kart� Hesab�)
            Her ay sonu istenirse bir miktar para yat�rma yap�labilir.
             */

            Doldur();
            BankaHesaplarimiGetir();
            txtHesapNo.ReadOnly = true;
        }

        private void Doldur()
        {
            var hesapTurleri = Enum.GetValues(typeof(HesapTurleri));
            foreach (var item in hesapTurleri)
            {
                cmbHesapTuru.Items.Add(item);
            }

            cmbIslemTuru.DataSource = Enum.GetValues(typeof(IslemTipleri));
        }

        BankAccount hesap;
        List<BankAccount> bankaHesaplarim = new();
        HesapTurleri secilenHesap;
        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            try
            {
                string owner = txtAdSoyad.Text;
                decimal initialBalance = Convert.ToDecimal(txtIlkBakiye.Text);

                if (secilenHesap == HesapTurleri.Interest_Earning_Account)
                {
                    hesap = new InterestEarningAccount(owner, initialBalance);
                }
                else if (secilenHesap == HesapTurleri.LineOf_Credit_Account)
                {
                    hesap = new LineOfCreditAccount(owner, initialBalance);
                }
                else if (secilenHesap == HesapTurleri.Gift_Card_Account)
                {
                    hesap = new GiftCardAccount(owner, initialBalance);
                }

                txtHesapNo.Text = hesap.Number;
                BakiyeGuncelle();
                bankaHesaplarim.Add(hesap);
                BankaHesaplarimiGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BankaHesaplarimiGetir()
        {
            lstHesapListesi.DataSource = null;
            lstHesapListesi.ValueMember = "Number";
            lstHesapListesi.DisplayMember = "Owner";
            lstHesapListesi.DataSource = bankaHesaplarim;
        }

        private void AlaniGoster()
        {
            txtAySonuBakiye.Visible = true;
            lblAySonu.Visible = true;
        }

        private void BakiyeGuncelle()
        {
            //hesap hareketlerini getir
            lblHesapHareketleri.Text = hesap.GetAccountHistory();

            //total bakiyeyi yazd�r.
            lblSonBakiye.Text = hesap.Balance.ToString() + " $";
        }

        private void cmbHesapTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenHesap = (HesapTurleri)cmbHesapTuru.SelectedItem;

            if (secilenHesap == HesapTurleri.Gift_Card_Account)
            {
                AlaniGoster();
            }
            else
            {
                AliniGizle();
            }

        }

        private void AliniGizle()
        {
            txtAySonuBakiye.Visible = false;
            lblAySonu.Visible = false;
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            //islem turune g�re yap�lacak i�lemi belirleyerek para �ekme ve yat�rma i�lemlerini yapal�m.
            IslemTipleri secilenIslemTipi = (IslemTipleri)cmbIslemTuru.SelectedItem;
            string not = txtNot.Text;
            decimal amount = Convert.ToDecimal(txtTutar.Text);

            if (secilenIslemTipi == IslemTipleri.Para_Cekme)
            {
                hesap.WithDrawal(amount, DateTime.Now, not);
            }
            else
            {
                hesap.MakeDeposit(amount, DateTime.Now, not);
            }

            BakiyeGuncelle();
        }

        private void lstHesapListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            hesap = (BankAccount)lstHesapListesi.SelectedItem;
            txtAdSoyad.Text = hesap.Owner;
            BakiyeGuncelle();
        }
    }
}
