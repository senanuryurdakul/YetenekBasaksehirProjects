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
            OPERATÖRLER:
            Karþýlaþtýrma Operatörleri  : <, >, <=, >=, ==, !=  
            Mantýksal Operatörler       : ve (&,&&), veya (|,||)
            Aritmetik Operatörler       :+,-,*,/,%
            Aktarma Operatörleri        :=, +=, -=, /=, *=
             */

            /*
            if (< kosul veya kosullar >) 
            {
                true bloðu
                kosul gercekleþirse burasý çalýþýr
            }else
            {
                false bloðu
                koþul gerçekleþmezse burasý çalýþýr.
            }
            */



            int sayi = 100;

            if (sayi >= 100)
            {
                MessageBox.Show("Sayý 100 den büyük veya eþittir..");
            }
            else
            {
                MessageBox.Show("Sayi 100 den küçüktür");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //&,&& Mantýksal Operatörü:

            //Ahmet'in sýnýfýný geçebilmesi için devamsýzlýk sayýsýnýn 10 günün altýnda ve not ortalamasýnýn 70'e eþit ve üzerinde olmasý gerekmektedir.

            byte devamsizlikSayisi = 7;
            byte notOrtalamasi = 68;

            if (devamsizlikSayisi < 10 && notOrtalamasi >= 70)
            {

            }
            else
            {

            }

            //&,&& operatörü:

            /*
             true, true > true
            false, true > false
            true, false> false
            false, false> false
             */


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ahmet'in sýnýfýný geçebilmesi için devamsýzlýk sayýsýnýn 10 günün altýnda veya not ortalamasýnýn 70'e eþitve üzerinde olmasý gerekmektedir.

            byte devamsizlikSayisi = 7;
            byte notOrtalamasi = 68;

            if (devamsizlikSayisi < 10 || notOrtalamasi >= 70)
            {

            }
            else
            {

            }

            //|,|| (veya) operatörü:
            /*
             true, false > true
            false, true > true
            true, true > true
            false, false > false
             */
        }
    }
}
