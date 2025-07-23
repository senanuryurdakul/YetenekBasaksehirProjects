using _17_RepositoryMantigi.Entities;

namespace _17_RepositoryMantigi.Repositories
{
    /*
     DB'ye bağlanarak tüm CRUD işlemlerimizi yapacak olan sınıftır. StudentRepository sınıfı IRepository interface'ini Student entitysi için implemente etmiştir.
     */
    public class StudentRepository : IRepository<Student>
    {
        private List<Student>? StudentList { get; set; } = new();

        public void Add(Student entity)
        {
            StudentList?.Add(entity);
        }

        public void Delete(string id)
        {
            /*
             StudentList?.Remove(student): StudentList nulldan farklı ise remove metodunu çağırıp çalıştırır, null ise hiçbir şey yapmaz.
             */

            //önce silinecek öğrenciyi FirstorDefault ile bulduk.
            var student = StudentList?.FirstOrDefault(x => x.ID == id);

            if (student == null)
            {
                throw new Exception("Silinecek öğrenci bulunamadı.");
            }
            //Daha sonra sildik.
            StudentList?.Remove(student);
        }

        public List<Student>? GetAll()
        {
            return StudentList;
        }

        public Student? GetByID(string id)
        {
            var std = StudentList?.FirstOrDefault(x => x.ID == id);
            return std;
        }

        public void Update(Student entity)
        {
            //sonra bakalım.
            var std = StudentList?.FirstOrDefault(x => x.ID == entity.ID);

            if (std != null)
            {
                std.Name = entity.Name;
                std.Surname = entity.Surname;
                std.BirthDate = entity.BirthDate;
                std.TC = entity.TC;
                std.IsActive = entity.IsActive;
            }
        }
    }
}
