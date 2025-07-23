using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Entities
{
    public class Registration : BaseEntity
    {
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public string? StudentID { get; set; }
        public string? CourseID { get; set; }
        public Course? Course { get; set; }
        public Student? Student { get; set; }
    }
}
