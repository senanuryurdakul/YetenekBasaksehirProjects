using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OOPTemelPersipler.Entities
{
    public class Order
    {
        //bir siparis oluşturulurken mutlaka siparis tarihi, müşteriid ve calisanid bilgileri girilsin.
        public Order(int empID, int cID, DateTime oDate)
        {
            EmployeeID = empID;
            CustomerID = cID;
            OrderDate = oDate;
        }

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public bool isActive { get; set; }
    }
}
