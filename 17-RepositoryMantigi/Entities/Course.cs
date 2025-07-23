using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Entities
{
    public class Course : BaseEntity
    {
        public string? CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? InstructorID { get; set; }
        public Instructor? Instructor { get; set; }

        //navigation property
        public List<Lesson>? Lessons { get; set; } = new();

        public override string ToString()
        {
            return $"{CourseName}/{StartDate}-{EndDate}";
        }
    }
}
