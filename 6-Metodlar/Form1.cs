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
            Program i�erisinde ayn� i�i yapan sat�rlar� belirli bir d�zende bir araya getirti�imiz yap�lard�r. Gerekti�inde �a��rarak tekrar tekrar kullanabiliriz. Metodlar sayesinde kod tekrar� yapmadan daha anla��l�r bir �ekilde kodlama yap�labilir.

            Direkt olarak �al��mazlar. Program i�erisinde �a��r�larak �a��l�rlar.

            Metod T�rleri:
            1-Geriye De�er D�nmeyen Metodlar
                a-Parametresiz Metodlar
                b-Parametreli Metodlar

            2-Geriye De�er D�nen Metodlar
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
            MessageBox.Show("Merhaba, Nas�ls�n�z?");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMessage("test");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SendMessage("Programa Ho� geldiniz.", "Kar��lama");
        }


        /// <summary>
        /// Ekrana kullan�c�dan ald��� de�erleri g�nderen bir mesaj penceresi a�ar.
        /// </summary>
        /// <param name="mesaj">Mesaj penceresi i�eri�i.</param>
        /// <param name="baslik">Mesaj penceresi ba�l���.</param>
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
           REF anahtar kelimesi C# dilinde i�aret�ilerin yerini tutar. Ref anahtar kelimesi kullan�lan de�i�kene mutlaka ve ilkleme i�lemi yap�lmal�d�r.  
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
            lstListe.Items.Add(soyad);      //Gen�
            lstListe.Items.Add(adSoyad);    //Kuzey Gen�    



        }
        private void CumleBirlestir(string ad, ref string soyad, out string adSoyad)
        {
            ad = "Kuzey";
            soyad = "Gen�";
            adSoyad = ad + " " + soyad;
        }
    }
}
