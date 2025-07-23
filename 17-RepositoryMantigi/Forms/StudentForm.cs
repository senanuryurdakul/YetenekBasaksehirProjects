using _17_RepositoryMantigi.Entities;
using _17_RepositoryMantigi.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_RepositoryMantigi.Forms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        StudentRepository sRepo = new StudentRepository();
        StudentManager sManager;
        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Student? secilen = (Student?)lstListe.SelectedItem;

                sManager = new StudentManager(sRepo);

                if (secilen == null)
                {
                    //yeni kayıt işlemi
                    Student s = new Student()
                    {
                        Name = txtAd.Text,
                        Surname = txtSoyad.Text,
                        BirthDate = Convert.ToDateTime(txtDTarihi.Text),
                        IsActive = true,
                        TC = txtTC.Text
                    };

                    sManager.Add(s);
                    FormuTemizle();
                }
                else
                {
                    //güncelleme işlemi
                    secilen.Name = txtAd.Text;
                    secilen.TC = txtTC.Text;
                    secilen.Surname = txtSoyad.Text;
                    secilen.BirthDate = Convert.ToDateTime(txtDTarihi.Text);

                    sManager.Update(secilen);
                    secilen = null;
                }

                OgrencileriGetir();
            }
            catch (Exception ex)
            {
                HataGoruntule(ex);
            }
        }

        private void FormuTemizle()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is MaskedTextBox)
                {
                    MaskedTextBox txtBox = (MaskedTextBox)item;
                    txtBox.Text = string.Empty;
                }
            }
        }

        private void OgrencileriGetir()
        {
            lstListe.DataSource = null;
            lstListe.ValueMember = "StudentID";
            lstListe.DataSource = sManager.GetAll();
            lstListe.SelectedIndex = -1;
        }

        private void HataGoruntule(Exception ex)
        {
            lblMesaj.BackColor = Color.DarkRed;
            lblMesaj.ForeColor = Color.White;
            lblMesaj.Text = ex.Message;
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Student? secilen = (Student?)lstListe.SelectedItem;
                sManager.Delete(secilen.ID);
                OgrencileriGetir();
            }
            catch (Exception ex)
            {
                HataGoruntule(ex);
            }
        }
    }
}
