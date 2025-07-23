namespace _2_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string ogrenci1 = "Ahmet Aksakal";
            //string ogrenci2 = "Caner Mollaoðlu";
            //string ogrenci3 = "Kuzey Mollaoðlu";

            //Diziler (Arrays)
            /*
             Dizi içerisinde ayný tipte birden çok deðeri tutabilen ve indis (index) numaralarý üzerinden bu deðerlere ulaþabildiðimiz bir veri yapýsýdýr. Dizi içerisinde bulunan deðerlere o dizinin elemanlarý denir. Dizi oluþturduðumuzda eleman sayýsý mutlaka tanýmlanmalýdýr.
             */

            //Dizi Oluþturma:
            string[] ogrenciler = new string[3];
            //Eleman Sayýsý: 3
            //Indis Degerleri: 0,1,2

            string[] countryInfo = new string[] { "Ýstanbul", "Ankara", "Ýzmir", "Malatya" };
            int[] sayilar = new int[4];
            bool[] cevaplar = new bool[10];

            //Diziye Eleman Atama: (set)
            ogrenciler[0] = "Caner Mollaoðlu";
            ogrenciler[1] = "Ahmet Aksakal";
            ogrenciler[2] = "Mesut Uzun";

            //Dizinin bulunmayan bir indexine eriþmeye çalýþtýk:
            //ogrenciler[3] = "Deneme Öðrenci"; //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

            //Diziden Deðer Okuma: (get)

            string deger = countryInfo[3];

        }

        //global deðiþken
        string[] ogrenciBilgileri = new string[1];
        int sayac = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            string adSoyad = $"{txtName.Text} {txtSurname.Text}";

            //string ad = txtName.Text;
            //string soyad=txtSurname.Text;
            //string nameSurname = ad + " " + soyad;
            ogrenciBilgileri[sayac] = adSoyad;
            sayac++;
            //sayac = sayac + 1;

            //Dizinin eleman sayýsýný bulma:
            int elemanSayisi = ogrenciBilgileri.Length;


            //Diziyi yeniden boyutlandýralým:
            Array.Resize(ref ogrenciBilgileri, elemanSayisi + 1);

        }
    }
}
