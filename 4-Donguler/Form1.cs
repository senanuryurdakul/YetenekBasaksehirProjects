namespace _4_Donguler
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
             DÖNGÜLER
            Program yazarken bazý kodlarý tekrar tekrar yazýyorsanýz orada bir hata yapýyorsunuz demektir. Dolayýsý ile kod tekrarý yapmak istediðimiz yerlerde döngü mekanizmalarýný kullanýrýz.
            for, while, do while, foreach
             */

            //listeye ekleme yapma:

            //lstListe.Items.Add("Caner");
            //lstListe.Items.Add(10.4434);
            //lstListe.Items.Add(true);
            //lstListe.Items.Add("Caner");

            //string[] liste = new string[] { "Ali", "Ayþe", "Ahmet" };

            //lstListe.Items.Add(liste[0]);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 5; i++)
            {
                //lstListe.Items.Add(i+" Ahmet");
                lstListe.Items.Add($"{i}. eleman Ahmet");
            }
        }

        string[] sehirListesi = { "Ýstanbul", "Ankara", "Malatya", "Mersin" };
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sehirListesi.Length; i++)
            {
                lstListe.Items.Add(sehirListesi[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayac = 0;

            while (sayac <= 10)
            {
                lstListe.Items.Add(sayac);
                sayac++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int counter = 1;
            foreach (var item in sehirListesi)
            {
                lstListe.Items.Add(counter + "-" + item);
                counter++;
            }

            //var tipi atama yapýlan tipe dönüþebilen bir deðiþken türüdür Karþý taraftan gelecek olan veri tipi bilinmediðinde ya da farklý türler gelebileceði zaman kullanýlýr.

            //var a = 5;
            //var b = "ahmet";
            //var c = true;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayac = 0;

            do
            {
                lstListe.Items.Add(sayac);
                sayac++;
            } while (sayac <= 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Continue
            //Dongüyü yazýldýðý noktadan itibaren bir sonraki tura geçirir.

            foreach (var item in sehirListesi)
            {
                if (item == "Malatya")
                {
                    continue;
                }
                lstListe.Items.Add(item);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Break:
            //Yazýldýðý noktadan itibaren döngüden çýkar.
            foreach (var item in sehirListesi)
            {
                if (item == "Malatya")
                {
                    break;
                }
                lstListe.Items.Add(item);
            }
        }
    }
}
