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
    public partial class CourseForm : Form
    {
        private readonly CourseManager _courseManager;
        private readonly LessonManager _lessonManager;
        private readonly InstuctorManager _instructorManager;
        public CourseForm()
        {
            InitializeComponent();
            CourseRepository cRepo = new CourseRepository();
            _courseManager = new CourseManager(cRepo);
            LessonRepository lRepo = new LessonRepository();
            _lessonManager = new LessonManager(lRepo);
            InstructorRepository instRepo = new InstructorRepository();
            _instructorManager = new InstuctorManager(instRepo);
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            //Egitmen Ekleyelim:
            AddInstructor();
            GetAllInstructors();
        }

        private void AddInstructor()
        {
            Instructor egitmen = new Instructor()
            {
                Name = "Ahmet",
                Surname = "Aksakal",
                Email = "ahmet@hotmail.com",
                Professions = "Yazılım Geliştirme",
                PhoneNumber = "5553234345",
                IsActive = true
            };

            _instructorManager.Add(egitmen);
        }

        private void GetAllInstructors()
        {
            cmbInstructor.DisplayMember = "FullName";
            cmbInstructor.ValueMember = "ID";
            cmbInstructor.DataSource = _instructorManager.GetAll();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            try
            {
                Lesson l = new Lesson()
                {
                    Title = txtLessonName.Text,
                    Duration = Convert.ToByte(txtLessonDuration.Text),
                    Date = dtLessonDate.Value,
                    Content = txtLessonContent.Text,
                    IsActive = true,
                    Time = txtLessonTime.Text,
                    CourseID = c.ID
                };

                _lessonManager.Add(l);
                c.Lessons.Add(l);
                //Listeye ekle
                lstLessonList.Items.Add(l.Title);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Course c;
        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                c = new Course()
                {
                    CourseName = txtCourseName.Text,
                    StartDate = dtStartDate.Value,
                    EndDate = dtEndDate.Value,
                    Instructor = (Instructor?)cmbInstructor.SelectedItem
                };

                _courseManager.Add(c);

                GetAllCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllCourses()
        {
            _courseManager.GetAll().ForEach(x => lstCourseList.Items.Add(x));
        }

        private void lstCourseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course? getCourse = lstCourseList.SelectedItem as Course;
        }
    }
}
