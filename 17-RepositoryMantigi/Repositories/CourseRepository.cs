using _17_RepositoryMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        private List<Course>? CourseList { get; set; } = new();

        public void Add(Course entity)
        {
            CourseList?.Add(entity);
        }

        public void Delete(string id)
        {
            var bulunanKurs = CourseList?.FirstOrDefault(c => c.ID == id);

            if (bulunanKurs == null)
            {
                throw new Exception("Kurs bulunamadı.");
            }

            CourseList?.Remove(bulunanKurs);
        }

        public List<Course>? GetAll()
        {
            return CourseList;
        }

        public Course? GetByID(string id)
        {
            return CourseList?.Find(x => x.ID == id);
        }

        public void Update(Course entity)
        {
            var course = CourseList?.FirstOrDefault(x => x.ID == entity.ID);

            if (course != null)
            {
                course.StartDate = entity.StartDate;
                course.EndDate = entity.EndDate;
                course.IsActive = entity.IsActive;
                course.CourseName = entity.CourseName;
                course.Instructor = entity.Instructor;
                course.Lessons = entity.Lessons;
            }
        }
    }
}
