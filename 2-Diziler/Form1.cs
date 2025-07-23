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
            //string ogrenci2 = "Caner Mollao�lu";
            //string ogrenci3 = "Kuzey Mollao�lu";

            //Diziler (Arrays)
            /*
             Dizi i�erisinde ayn� tipte birden �ok de�eri tutabilen ve indis (index) numaralar� �zerinden bu de�erlere ula�abildi�imiz bir veri yap�s�d�r. Dizi i�erisinde bulunan de�erlere o dizinin elemanlar� denir. Dizi olu�turdu�umuzda eleman say�s� mutlaka tan�mlanmal�d�r.
             */

            //Dizi Olu�turma:
            string[] ogrenciler = new string[3];
            //Eleman Say�s�: 3
            //Indis Degerleri: 0,1,2

            string[] countryInfo = new string[] { "�stanbul", "Ankara", "�zmir", "Malatya" };
            int[] sayilar = new int[4];
            bool[] cevaplar = new bool[10];

            //Diziye Eleman Atama: (set)
            ogrenciler[0] = "Caner Mollao�lu";
            ogrenciler[1] = "Ahmet Aksakal";
            ogrenciler[2] = "Mesut Uzun";

            //Dizinin bulunmayan bir indexine eri�meye �al��t�k:
            //ogrenciler[3] = "Deneme ��renci"; //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

            //Diziden De�er Okuma: (get)

            string deger = countryInfo[3];

        }

        //global de�i�ken
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

            //Dizinin eleman say�s�n� bulma:
            int elemanSayisi = ogrenciBilgileri.Length;


            //Diziyi yeniden boyutland�ral�m:
            Array.Resize(ref ogrenciBilgileri, elemanSayisi + 1);

        }
    }
}
