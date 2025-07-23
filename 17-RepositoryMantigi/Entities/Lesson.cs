using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Entities
{
    public class Lesson : BaseEntity
    {
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public byte Duration { get; set; }
        public string? Content { get; set; }
        public string? CourseID { get; set; }
        public string? Time { get; set; }

        //navigation property
        public Course? Course { get; set; }
    }
}
