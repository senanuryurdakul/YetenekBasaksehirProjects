using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPTemelPresipler2.Entities
{
    public class Product
    {
        public int ID { get; set; }

        //ENCAPSULATION
        private string? _productname;
        public string? ProductName
        {
            get { return _productname.ToUpper(); }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _productname = value;
                }
                else
                {
                    throw new ArgumentException("Ürün adı boş olamaz.");
                }

            }
        }

        private double _price;

        public double UnitPrice
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new Exception("Negatif değer atanamaz.");
                }
            }
        }

        public int StockQuantity { get; set; }
    }
}
