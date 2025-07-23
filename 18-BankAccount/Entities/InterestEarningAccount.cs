using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_BankAccount.Entities
{
    public class InterestEarningAccount : BankAccount,IMonthEndPerform
    {
        public InterestEarningAccount(string nameSurname, decimal initialBalance) : base(nameSurname, initialBalance)
        {

        }

        public void PerformMonthEndTransaction()
        {
            if (Balance>500)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "Aylık faiz getirisi hesaba yatırıldı.");
            }
        }
    }
}
