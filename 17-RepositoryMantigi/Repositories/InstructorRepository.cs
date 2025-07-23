using _17_RepositoryMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Repositories
{
    public class InstructorRepository : IRepository<Instructor>
    {
        private List<Instructor>? InstructorList { get; set; } = new();

        public void Add(Instructor entity)
        {
            InstructorList?.Add(entity);
        }

        public void Delete(string id)
        {
            var bulunan = InstructorList?.FirstOrDefault(c => c.ID == id);

            if (bulunan == null)
            {
                throw new Exception("Eğitmen bulunamadı.");
            }

            InstructorList?.Remove(bulunan);
        }

        public List<Instructor>? GetAll()
        {
            return InstructorList;
        }

        public Instructor? GetByID(string id)
        {
            return InstructorList?.Find(x => x.ID == id);
        }

        public void Update(Instructor entity)
        {
            var Instructor = InstructorList?.FirstOrDefault(x => x.ID == entity.ID);

            if (Instructor != null)
            {
                Instructor.Professions = entity.Professions;
                Instructor.Name = entity.Name;
                Instructor.Email = entity.Email;
                Instructor.Courses = entity.Courses;
                Instructor.Surname = entity.Surname;
                Instructor.PhoneNumber = entity.PhoneNumber;
            }
        }

    }
}