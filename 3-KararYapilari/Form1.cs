namespace _3_KararYapilari
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
             IF KARAR YAPILARI
            OPERAT�RLER:
            Kar��la�t�rma Operat�rleri  : <, >, <=, >=, ==, !=  
            Mant�ksal Operat�rler       : ve (&,&&), veya (|,||)
            Aritmetik Operat�rler       :+,-,*,/,%
            Aktarma Operat�rleri        :=, +=, -=, /=, *=
             */

            /*
            if (< kosul veya kosullar >) 
            {
                true blo�u
                kosul gercekle�irse buras� �al���r
            }else
            {
                false blo�u
                ko�ul ger�ekle�mezse buras� �al���r.
            }
            */



            int sayi = 100;

            if (sayi >= 100)
            {
                MessageBox.Show("Say� 100 den b�y�k veya e�ittir..");
            }
            else
            {
                MessageBox.Show("Sayi 100 den k���kt�r");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //&,&& Mant�ksal Operat�r�:

            //Ahmet'in s�n�f�n� ge�ebilmesi i�in devams�zl�k say�s�n�n 10 g�n�n alt�nda ve not ortalamas�n�n 70'e e�it ve �zerinde olmas� gerekmektedir.

            byte devamsizlikSayisi = 7;
            byte notOrtalamasi = 68;

            if (devamsizlikSayisi < 10 && notOrtalamasi >= 70)
            {

            }
            else
            {

            }

            //&,&& operat�r�:

            /*
             true, true > true
            false, true > false
            true, false> false
            false, false> false
             */


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ahmet'in s�n�f�n� ge�ebilmesi i�in devams�zl�k say�s�n�n 10 g�n�n alt�nda veya not ortalamas�n�n 70'e e�itve �zerinde olmas� gerekmektedir.

            byte devamsizlikSayisi = 7;
            byte notOrtalamasi = 68;

            if (devamsizlikSayisi < 10 || notOrtalamasi >= 70)
            {

            }
            else
            {

            }

            //|,|| (veya) operat�r�:
            /*
             true, false > true
            false, true > true
            true, true > true
            false, false > false
             */
        }
    }
}
