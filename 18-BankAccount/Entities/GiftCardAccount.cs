using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_BankAccount.Entities
{
    public class GiftCardAccount : BankAccount, IMonthEndPerform
    {
        private decimal _monthlyDeposit;
        public GiftCardAccount(string nameSurname, decimal initialBalance, decimal monthlyPay = 0) : base(nameSurname, initialBalance)
        {
            _monthlyDeposit = monthlyPay;
        }

        public void PerformMonthEndTransaction()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Aylık ekstra yatırma yapıldı.");
            }
        }
    }
}
