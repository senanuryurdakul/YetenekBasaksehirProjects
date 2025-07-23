using _17_RepositoryMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Repositories
{
    public class CourseManager : IRepository<Course>
    {
        //readonly

        private readonly CourseRepository _courseRepository;
        public CourseManager(CourseRepository crepo)
        {
            _courseRepository = crepo;
        }

        public void Add(Course entity)
        {
            if (entity != null)
            {
                _courseRepository.Add(entity);
            }
        }

        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("Id bilgisi boş olmaz.");
            }

            _courseRepository?.Delete(id);
        }

        public List<Course>? GetAll()
        {
            //??
            //null-colesing operatörü
            //_courseRepository.GetAll() metodu null dönerse hata fırlatır.
            return _courseRepository.GetAll() ?? throw new Exception("Liste Bulunamadı.");
        }

        public Course GetByID(string id)
        {
            return _courseRepository.GetByID(id) ?? throw new Exception("Kurs bulunamadı.");
        }

        public void Update(Course entity)
        {
            if (entity != null)
            {
                _courseRepository.Update(entity);
            }
        }
    }
}
