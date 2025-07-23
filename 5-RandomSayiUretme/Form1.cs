namespace _5_RandomSayiUretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] secilenSayilar = new int[6];
        private void btnRandom_Click(object sender, EventArgs e)
        {
            //instance (örnek alma)
            Random rnd = new Random();
            int randomSayi;

            //diziyi benzersiz sayýlarla dolduralým:
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    randomSayi = rnd.Next(0, 50);

                } while (secilenSayilar.Contains(randomSayi));

                secilenSayilar[i] = randomSayi;
            }

            //diziden tüm sayýlarý okuyarak listeye ekleyelim:
            lstListe.Items.Clear();
            foreach (var item in secilenSayilar)
            {
                lstListe.Items.Add(item);
            }


            //Random ahmet = new Random();
            //bool cevap = sayilar.Contains(12);

        }
    }
}
