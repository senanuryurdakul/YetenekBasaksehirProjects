using _12_OOPTemelPersipler.Entities;

namespace _12_OOPTemelPersipler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ogrenci Kaydý Yapalým:

            string ogrenciAdi = "Ahmet";
            string orenciSoyadi = "Aksakal";
            byte ogrenciYasi = 24;
            string okulu = "Bahcesehir Ünv.";
            string bolumu = "Bilgisayar Müh.";
            double okulUcreti = 250000;

            string ogrenciAdi1 = "Osman";
            string orenciSoyadi1 = "Mavi";
            byte ogrenciYasi1 = 24;
            string okulu1 = "Bahcesehir Ünv.";
            string bolumu1 = "Bilgisayar Müh.";
            int okulUcreti1 = 250000;

            string studentNameSurname = "";
            string department = "";
            string schoolName = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Student adlý sýnýfýmýzdan bir adet Student nesnesi oluþturalým:
            Student ogrenci1 = new Student();
            ogrenci1.Name = "Ahmet";
            ogrenci1.Surname = "Aksakal";
            ogrenci1.Email = "ahmet@hotmail.com";
            ogrenci1.StudentID = 1;
            ogrenci1.SchoolName = "Ýstanbul Eðitim Akademi";
            ogrenci1.SchoolPrice = 150000;

            Student std = new Student()
            {
                Name = "Osman",
                Surname = "Güneþ",
                Email = "osman@gmail.com",
                StudentID = 2,
                SchoolPrice = 56000,
                SchoolName = "Bau",
                Department = "Fen Bilimleleri"
            };

            //get
            string adSoyad = $"{std.Name} {std.Surname}";

            //set
            std.Name = "Ali";
            std.Surname = "Gün";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student std = new Student("Ahmet", "Aksakal");
            std.Name = "Caner";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.IsActive = false;
            c.Email = "caner@gmail.com";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order o = new Order(102, 450, DateTime.Now);
        }
    }
}
