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
             Hesap Açýlýþ Ýþlemi
            Otomatik olarak bir hesap numarasý oluþturulmalýdýr.
            Hesap açarken mutlaka hesap sahibinin adý soyadý ve ilk bakiye girilmelidir.

            Hesaptan Para Çekebilmeliyiz
            Hesapta para yoksa para çekme islemi yapýlamasýn.

            Hesaba Para Yatýrabilmeliyiz
            Para yatýrýrken 0 dan büyük bir deðer olmasý saðlanmalýdýr.

            1-InterestEarningAccount (Faiz Getiri Hesabý)
            Eðer mevcut bakiye 500 dolardan fazla ise her ay sonu %5 faiz getirisi saðlar.

            2-LineOfCreditAccount (Kredi Limit Hesabý)
            ???Eksi bakiyeye düþebilir. Ancak eksi bakiye söz konusu ise her ay sonu %7 faiz gideri uygulanacaktýr.

            3-GiftCardAccount (Hediye Kartý Hesabý)
            Her ay sonu istenirse bir miktar para yatýrma yapýlabilir.
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

            //total bakiyeyi yazdýr.
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
            //islem turune göre yapýlacak iþlemi belirleyerek para çekme ve yatýrma iþlemlerini yapalým.
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
