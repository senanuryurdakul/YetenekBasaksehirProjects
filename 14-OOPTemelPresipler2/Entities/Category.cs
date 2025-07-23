using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPTemelPresipler2.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string? CategoryName { get; set; }
        private string? _description;

        public string? Description
        {
            get { return _description; }
            set
            {
                if (value.Length >= 20)
                {
                    _description = value;
                }
                else
                {
                    throw new Exception("Açıklama miminum 20 karakter olmalıdır.");
                }
                
            }
        }

    }
}
