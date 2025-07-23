namespace _9_KelimeOyunuV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kelime;
        private void btnOyna_Click(object sender, EventArgs e)
        {
            //bir adet buton groupbox'a eklendi:
            //Button btn = new Button();
            //btn.Size = new Size(90, 90);
            //btn.Location = new Point(40, 100);
            //btn.Text = "--";
            //btn.Name = "btn1";
            //grpHarfler.Controls.Add(btn);

            //girilen kelimenin harf sayýsý kadar buton ekleyelim:

            kelime = txtKelime.Text;
            grpHarfler.Controls.Clear();
            for (int i = 0; i < kelime.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(90, 90);
                btn.Location = new Point(40 + (i * 100), 60);
                btn.Text = "--";
                btn.Name = "btn" + i;
                btn.Tag = i;
                btn.Click += Btn_Click;
                grpHarfler.Controls.Add(btn);
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = Convert.ToInt32(btn.Tag);

            btn.Text = kelime[index].ToString().ToUpper();
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
