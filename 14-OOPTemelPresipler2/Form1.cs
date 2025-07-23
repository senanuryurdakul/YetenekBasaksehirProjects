using _14_OOPTemelPresipler2.Entities;

namespace _14_OOPTemelPresipler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = "Mikrofon";

            string name = p.ProductName;

            p.UnitPrice = 5600;

            Category ct= new Category();
            ct.Description = "yeni bir urunyeni bir urunyeni bir urunyeni bir urunyeni bir urunyeni bir urunyeni bir urunyeni bir urun";
        }
    }
}
