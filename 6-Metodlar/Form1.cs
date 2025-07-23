namespace _6_Metodlar
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
             METODLAR
            Program içerisinde ayný iþi yapan satýrlarý belirli bir düzende bir araya getirtiðimiz yapýlardýr. Gerektiðinde çaðýrarak tekrar tekrar kullanabiliriz. Metodlar sayesinde kod tekrarý yapmadan daha anlaþýlýr bir þekilde kodlama yapýlabilir.

            Direkt olarak çalýþmazlar. Program içerisinde çaðýrýlarak çaþýlýrlar.

            Metod Türleri:
            1-Geriye Deðer Dönmeyen Metodlar
                a-Parametresiz Metodlar
                b-Parametreli Metodlar

            2-Geriye Deðer Dönen Metodlar
                a-Parametresiz Metodlar
                b-Parametreli Metodlar
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selamlama();
        }

        private void Selamlama()
        {
            MessageBox.Show("Merhaba, Nasýlsýnýz?");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMessage("test");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SendMessage("Programa Hoþ geldiniz.", "Karþýlama");
        }


        /// <summary>
        /// Ekrana kullanýcýdan aldýðý deðerleri gönderen bir mesaj penceresi açar.
        /// </summary>
        /// <param name="mesaj">Mesaj penceresi içeriði.</param>
        /// <param name="baslik">Mesaj penceresi baþlýðý.</param>
        private void SendMessage(string mesaj, string baslik)
        {
            //MessageBox.Show(mesaj);
            MessageBox.Show(mesaj, baslik);
        }

        private void SendMessage(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        bool[] cevaplar = new bool[] { true, false, true, false, false, false };
        int[] sayiDizisi = new int[] { 54, 67, 89, 76 };
        private void button4_Click(object sender, EventArgs e)
        {
            ResetArray(cevaplar, false);
        }

        private void ResetArray(bool[] dizim, bool deger)
        {
            for (int i = 0; i < dizim.Length; i++)
            {
                dizim[i] = deger;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string deger = MesajGonder();
            int sonuc = ToplamaYap(560, 450);
            int toplam = ToplamaYap(sayiDizisi);
            int toplamSonuc = ToplamaYap(true, 3, 34, 55, 34, 23, 23, 453, 23);
        }

        private int ToplamaYap(int a, int b)
        {
            return a + b;
        }

        private int ToplamaYap(int[] dizi)
        {
            int sonuc = 0;
            foreach (var item in dizi)
            {
                sonuc += item;
            }

            return sonuc;
        }

        private int ToplamaYap(bool durum, params int[] dizi)
        {
            int sonuc = 0;
            foreach (var item in dizi)
            {
                sonuc += item;
            }

            return sonuc;
        }


        private string MesajGonder()
        {
            return "Selam";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            /*
           REF anahtar kelimesi C# dilinde iþaretçilerin yerini tutar. Ref anahtar kelimesi kullanýlan deðiþkene mutlaka ve ilkleme iþlemi yapýlmalýdýr.  
             */

            int sayi = 10;
            DegerDegistir(ref sayi);
            lblMesaj.Text = sayi.ToString();

        }

        private void DegerDegistir(ref int sayi)
        {
            sayi = 50;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ad = "Ahmet";
            string soyad = "Aksakal";
            string adSoyad;

            CumleBirlestir(ad, ref soyad, out adSoyad);

            lstListe.Items.Add(ad);         //Ahmet
            lstListe.Items.Add(soyad);      //Genç
            lstListe.Items.Add(adSoyad);    //Kuzey Genç    



        }
        private void CumleBirlestir(string ad, ref string soyad, out string adSoyad)
        {
            ad = "Kuzey";
            soyad = "Genç";
            adSoyad = ad + " " + soyad;
        }
    }
}
