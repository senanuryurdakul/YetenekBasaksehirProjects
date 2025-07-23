using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_BankAccount.Entities
{
    public class LineOfCreditAccount : BankAccount, IMonthEndPerform
    {
        public LineOfCreditAccount(string nameSurname, decimal initialBalance) : base(nameSurname, initialBalance)
        {
        }

        public override void WithDrawal(decimal amt, DateTime dt, string nt)
        {
            if (amt <= 0)
            {
                throw new Exception("Çekilen tutar 0 dan büyük olmalıdır.");
            }

            var withdrawal = new Transaction(-amt, dt, nt);
            _alTransactions.Add(withdrawal);
        }
        public void PerformMonthEndTransaction()
        {
            if (Balance < 0)
            {
                decimal interest = Balance * 0.07m;
                WithDrawal(interest, DateTime.Now, "Hesaptan aylık faiz gideri alındı.");
            }
        }
    }
}
