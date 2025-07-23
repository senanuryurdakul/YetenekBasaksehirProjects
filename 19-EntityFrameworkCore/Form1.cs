using _19_EntityFrameworkCore.DAL;
using _19_EntityFrameworkCore.Entities;
using _19_EntityFrameworkCore.Repositories;

namespace _19_EntityFrameworkCore
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        CategoryRepository cRepo;
        CategoryManager cManager;
        private void Form1_Load(object sender, EventArgs e)
        {
            cRepo = new CategoryRepository(_context);
            cManager = new CategoryManager(cRepo);

            Category c = new Category()
            {
                CategoryName = "Teknoloji",
                Description = "Tüm teknoloji ürünleri."
            };

            cManager.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cManager.DeleteById(4);
            ListeyiDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category oldCategory = cManager.GetById(1);
            oldCategory.CategoryName = "Test güncelleme";

            cManager.Update(oldCategory);
            ListeyiDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            lstListe.Items.Clear();
            cManager.GetAll().ForEach(x => lstListe.Items.Add(x.CategoryName));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var gelenKategori = cManager.GetById(1);
            lstListe.Items.Add(gelenKategori?.CategoryName ?? "-");
        }
    }
}
