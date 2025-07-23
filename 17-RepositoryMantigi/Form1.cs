using _17_RepositoryMantigi.Forms;
using _17_RepositoryMantigi.Repositories;

namespace _17_RepositoryMantigi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void öðrenciTanýmlarýToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Formun instance anýlýr.
            StudentForm stdForm = new StudentForm();
            stdForm.MdiParent = this;

            FormKontrol(stdForm);
        }

        private void FormKontrol(Form frm)
        {
            bool acikMi = false;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == frm.GetType())
                {
                    acikMi = true;
                }
            }

            if (acikMi)
            {
                MessageBox.Show("Form zaten açýk durumda.");
            }
            else
            {
                frm.Show();
            }
        }

        private void kursTanýmlarýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseForm cForm=new CourseForm();
            cForm.MdiParent = this;
            FormKontrol(cForm);
        }
    }
}
