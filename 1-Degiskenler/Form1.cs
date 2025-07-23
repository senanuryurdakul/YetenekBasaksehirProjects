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
            //yorum satýrý
            /*
            çoklu
            yorum 
            satýrý
            oluþtura
             */

            /*
             DEGÝSKENLER (Variables)
            Bilgisayar belleðinde bazý deðerleri tutmaya yarayan yapýladýr.
             */

            byte stokMiktari = 60;
            int sayi = 5;
            short deger = 32000;

            float ondalik1 = 454.43f;
            double ondalik2 = 5455.22;
            decimal ondalik3 = 3424.23m;

            string adSoyad = "Ahmet Aksakal";
            char karakter = 'E';

            //isimlendirme standartý olarak camelCase kullanýyoruz.

            //C# case sensitive bir dildir. Yani büyük küçük harf duyarlýdýr.

            //bu iki deðiþken de farklýdýr.
            string adres = "Beþiktaþ";
            string Adres = "Etiler";

            //C# ta deðiþkenler iki gruba ayrýlýr:

            //Value Type (Ram'in stack adlý bölümünde tutular.)
            //Reference Type (Ram'in heap adlý bölümünde tutular.)

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
