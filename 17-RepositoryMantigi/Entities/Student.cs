using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Entities
{
    public class Student : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Fullname => $"{Name} {Surname}";
        public DateTime BirthDate { get; set; }
        public string? TC { get; set; }

        public override string ToString()
        {
            return $"{TC}-{Fullname}";
        }
    }
}
