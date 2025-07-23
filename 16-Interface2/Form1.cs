using _16_Interface2.Entities;

namespace _16_Interface2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BankManagerV1 bm = new BankManagerV1();
            //bm.Ekle(1);,

            GarantiBankasi g=new GarantiBankasi();
            //ZiraatBankasi z = new ZiraatBankasi();
            BankManager bm = new BankManager(g);
            MessageBox.Show(bm.Ekle());



        }
    }
}
