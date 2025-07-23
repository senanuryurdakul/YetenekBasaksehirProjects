namespace _10_KelimeOyunuVer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string[] iller = { "Ýstanbul", "Ankara", "Ýzmir", "Antalya", "Bursa" };
        string[] secilenIller = new string[1];
        char[] harflerim = {
    'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ð', 'H', 'I', 'Ý', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'T', 'U', 'Ü', 'V', 'Y', 'Z'
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            AlfabeOlustur();
        }

        private void AlfabeOlustur()
        {
            for (int i = 0; i < harflerim.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(90, 90);
                //btn.Location = new Point(40 + (i * 100), 60);
                btn.Text = harflerim[i].ToString();
                btn.Name = "btn" + i;
                btn.Tag = i;
                btn.Enabled = false;
                btn.Click += Btn_Click;
                flwHarfler.Controls.Add(btn);
            }
        }

        byte hak;
        byte dogruSayisi = 0;
        private void Btn_Click(object? sender, EventArgs e)
        {
            //Basýlan butonu ve üzerindeki harfi yakalamamýz gerekiyor:
            //11:10 devam ediyoruz.
            Button secilenButon = sender as Button;
            bool buldunMu = false;
            secilenButon.Enabled = false;

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secilenKelime[i].ToString().ToLower() == secilenButon.Text.ToLower())
                {
                    grpKelime.Controls[i].Text = secilenButon.Text;
                    dogruSayisi++;
                    lblDogru.Text = dogruSayisi.ToString();
                    buldunMu = true;
                }
            }

            //buldunMu==false
            if (!buldunMu)
            {
                hak--;
                lblHak.Text = hak.ToString();
            }

            if (hak == 0)
            {
                OyunSonuKotrol("Kaybettiniz.");
            }

            if (dogruSayisi == secilenKelime.Length)
            {
                OyunSonuKotrol("Kazandýnýz.");
            }
        }
        private void OyunSonuKotrol(string mesaj)
        {
            DialogResult cvp = MessageBox.Show($"Oyun Bitti. {mesaj} Yeniden oynamak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cvp == DialogResult.Yes)
            {
                btnOyna.PerformClick();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            OyunuSifirla();

            //Dizi içerisinden random olarak bezersiz bir il seçelim:
            RandomSehirSec();
            MessageBox.Show(secilenKelime);
            ButonlariAyarla();
            hak = (byte)secilenKelime.Length;
            lblHak.Text = hak.ToString();

        }

        private void OyunuSifirla()
        {
            hak = 0;
            lblHak.Text = hak.ToString();
            dogruSayisi = 0;
            lblDogru.Text = dogruSayisi.ToString();

            foreach (var item in flwHarfler.Controls)
            {
                Button btn = item as Button;
                btn.Enabled = true;
            }
        }

        private void ButonlariAyarla()
        {
            grpKelime.Controls.Clear();

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(90, 90);
                btn.Location = new Point(40 + (i * 100), 60);
                btn.Text = "--";
                btn.Name = "btnK" + i;
                btn.Tag = i;
                grpKelime.Controls.Add(btn);
            }
        }

        string secilenKelime;
        int sayac = 0;
        private void RandomSehirSec()
        {
            //bütün iller seçildikten sonra tekrar baþa dönmek için bu kontrolü kullandýk:
            if (secilenIller.Length == iller.Length)
            {
                secilenIller = new string[1];
                sayac = 0;
            }

            //secilenIller dizisi için benzersiz iller bulur:
            do
            {
                //random secimi yap
                Random rnd = new Random();
                int rastgeleSayi = rnd.Next(0, iller.Length);
                secilenKelime = iller[rastgeleSayi];


            } while (secilenIller.Contains(secilenKelime));

            //secilenIller dizisine ekle
            secilenIller[sayac] = secilenKelime;
            sayac++;
            Array.Resize(ref secilenIller, secilenIller.Length + 1);
        }
    }
}
