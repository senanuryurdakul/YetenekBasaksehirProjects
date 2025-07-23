using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_EFCoreCourseApp.Forms
{
    public partial class StudentForm : BaseForm
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student form");
        }
    }
}
