using _17_RepositoryMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Repositories
{
    public class InstuctorManager : IRepository<Instructor>
    {
        //readonly

        private readonly InstructorRepository _instructorRepository;
        public InstuctorManager(InstructorRepository IRepo)
        {
            _instructorRepository = IRepo;
        }

        public void Add(Instructor entity)
        {
            if (entity != null)
            {
                _instructorRepository.Add(entity);
            }
        }

        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("Id bilgisi boş olmaz.");
            }

            _instructorRepository?.Delete(id);
        }

        public List<Instructor>? GetAll()
        {
            //??
            //null-colesing operatörü
            //_instructorRepository.GetAll() metodu null dönerse hata fırlatır.
            return _instructorRepository.GetAll() ?? throw new Exception("Liste Bulunamadı.");
        }

        public Instructor GetByID(string id)
        {
            return _instructorRepository.GetByID(id) ?? throw new Exception("Kurs bulunamadı.");
        }

        public void Update(Instructor entity)
        {
            if (entity != null)
            {
                _instructorRepository.Update(entity);
            }
        }
    }

}
