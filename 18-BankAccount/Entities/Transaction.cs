using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_BankAccount.Entities
{
    //Ctrl + . (nokta)  >> Use Primary Constructor
    public class Transaction(decimal amt, DateTime dt, string nt)
    {
        public decimal Amount { get; set; } = amt;
        public DateTime Date { get; set; } = dt;
        public string? Note { get; set; } = nt;
    }
}
