using _17_RepositoryMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Repositories
{
    public class LessonRepository : IRepository<Lesson>
    {
        private List<Lesson> LessonList { get; set; } = new();
        public void Add(Lesson entity)
        {
            LessonList.Add(entity);
        }

        public void Delete(string id)
        {
            var lesson = LessonList.FirstOrDefault(x => x.ID == id);
            if (lesson != null)
            {
                LessonList.Remove(lesson);
            }
        }

        public List<Lesson> GetAll()
        {
            return LessonList;
        }

        public Lesson? GetByID(string id)
        {
            var lesson = LessonList?.FirstOrDefault(x => x.ID == id);
            return lesson;
        }

        public void Update(Lesson entity)
        {
            var lesson = LessonList?.FirstOrDefault(x => x.ID == entity.ID);
            if (lesson != null)
            {
                lesson.Title = entity.Title;
                lesson.Course = entity.Course;
                lesson.IsActive = entity.IsActive;
                lesson.Content = entity.Content;
                lesson.Duration = entity.Duration;
                lesson.Date = entity.Date;
            }
        }
    }
}
