using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OOPTemelPersipler.Entities
{
    //Access Modifiers (Erişim Belirleyiciler)
    //public, private, protected, internal
    public class Student
    {
        //Yapıcı Metod
        //Constructor
        //ctor > tab
        public Student(string ad,string soyad)
        {
            Name = ad;
            Surname = soyad;
        }

        public Student()
        {
            
        }

        //field (alan)
        //private olarak tanımlanan class yapılarıdır.
        private string _nameSurname;
        private byte _yas;


        //property (degiskenler)
        //public olur, dışarıdan ulaşılabilir.
        public int StudentID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string[]? Degerler { get; set; }
        public byte Yas { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double SchoolPrice { get; set; }
        public string? SchoolName { get; set; }
        public string? Department { get; set; }

        //methods (metodlar)
        public void EnrollInCourse()
        {

        }

        public int GetAge()
        {
            var bugun = DateTime.Today;
            int age = bugun.Year - DogumTarihi.Year;
            return age;
        }
    }
}
