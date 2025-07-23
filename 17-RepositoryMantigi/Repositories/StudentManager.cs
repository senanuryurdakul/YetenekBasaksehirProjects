using _17_RepositoryMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Repositories
{
    /*
     Manager sınıfı datayı Repository'ye göndermeden önce kontrol eder. Gereken tüm iş kurallarını koyar ve validation kontrollerini yapar.
     */
    public class StudentManager : IRepository<Student>
    {
        private StudentRepository _studentRepository;
        public StudentManager(StudentRepository sRepo)
        {
            _studentRepository = sRepo;
        }
        public void Add(Student entity)
        {
            if (entity != null)
            {
                var student = _studentRepository.GetAll().FirstOrDefault(x=>x.TC==entity.TC);

                if (student!=null)
                {
                    throw new Exception("Öğrenci daha önce sisteme girilmiş.");
                }

                if (string.IsNullOrEmpty(entity.Name) && string.IsNullOrEmpty(entity.Surname))
                {
                    throw new Exception("Lütfen Ad ve Soyad bilgilerini giriniz.");
                }

                _studentRepository.Add(entity);
            }
        }

        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("Id bilgisi boş olamaz.");
            }

            _studentRepository.Delete(id);
        }

        public List<Student>? GetAll()
        {
            var students = _studentRepository.GetAll();

            if (students==null)
            {
                throw new Exception("Öğrenci listesi bulunamadı.");
            }

            return _studentRepository.GetAll();
        }

        public Student? GetByID(string id)
        {
            var std=_studentRepository.GetByID(id);

            if (std==null)
            {
                throw new Exception("Öğrenci bulunamadı.");
            }

            return std;
        }

        public void Update(Student entity)
        {
            if (entity!=null)
            {
                _studentRepository.Update(entity);
            }
        }
    }
}
