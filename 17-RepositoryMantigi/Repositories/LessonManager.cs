using _17_RepositoryMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Repositories
{
    public class LessonManager : IRepository<Lesson>
    {
        //readonly

        private readonly LessonRepository _lessonRepository;
        public LessonManager(LessonRepository lRepo)
        {
            _lessonRepository = lRepo;
        }

        public void Add(Lesson entity)
        {
            if (entity != null)
            {
                _lessonRepository.Add(entity);
            }
        }

        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("Id bilgisi boş olmaz.");
            }

            _lessonRepository?.Delete(id);
        }

        public List<Lesson>? GetAll()
        {
            //??
            //null-colesing operatörü
            //_lessonRepository.GetAll() metodu null dönerse hata fırlatır.
            return _lessonRepository.GetAll() ?? throw new Exception("Liste Bulunamadı.");
        }

        public Lesson GetByID(string id)
        {
            return _lessonRepository.GetByID(id) ?? throw new Exception("Kurs bulunamadı.");
        }

        public void Update(Lesson entity)
        {
            if (entity != null)
            {
                _lessonRepository.Update(entity);
            }
        }
    }
}
