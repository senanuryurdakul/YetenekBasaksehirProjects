namespace _1_Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //yorum sat�r�
            /*
            �oklu
            yorum 
            sat�r�
            olu�tura
             */

            /*
             DEG�SKENLER (Variables)
            Bilgisayar belle�inde baz� de�erleri tutmaya yarayan yap�lad�r.
             */

            byte stokMiktari = 60;
            int sayi = 5;
            short deger = 32000;

            float ondalik1 = 454.43f;
            double ondalik2 = 5455.22;
            decimal ondalik3 = 3424.23m;

            string adSoyad = "Ahmet Aksakal";
            char karakter = 'E';

            //isimlendirme standart� olarak camelCase kullan�yoruz.

            //C# case sensitive bir dildir. Yani b�y�k k���k harf duyarl�d�r.

            //bu iki de�i�ken de farkl�d�r.
            string adres = "Be�ikta�";
            string Adres = "Etiler";

            //C# ta de�i�kenler iki gruba ayr�l�r:

            //Value Type (Ram'in stack adl� b�l�m�nde tutular.)
            //Reference Type (Ram'in heap adl� b�l�m�nde tutular.)

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
