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
             D�NG�LER
            Program yazarken baz� kodlar� tekrar tekrar yaz�yorsan�z orada bir hata yap�yorsunuz demektir. Dolay�s� ile kod tekrar� yapmak istedi�imiz yerlerde d�ng� mekanizmalar�n� kullan�r�z.
            for, while, do while, foreach
             */

            //listeye ekleme yapma:

            //lstListe.Items.Add("Caner");
            //lstListe.Items.Add(10.4434);
            //lstListe.Items.Add(true);
            //lstListe.Items.Add("Caner");

            //string[] liste = new string[] { "Ali", "Ay�e", "Ahmet" };

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

        string[] sehirListesi = { "�stanbul", "Ankara", "Malatya", "Mersin" };
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

            //var tipi atama yap�lan tipe d�n��ebilen bir de�i�ken t�r�d�r Kar�� taraftan gelecek olan veri tipi bilinmedi�inde ya da farkl� t�rler gelebilece�i zaman kullan�l�r.

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
            //Dong�y� yaz�ld��� noktadan itibaren bir sonraki tura ge�irir.

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
            //Yaz�ld��� noktadan itibaren d�ng�den ��kar.
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
