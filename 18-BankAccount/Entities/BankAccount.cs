using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_BankAccount.Entities
{
    public class BankAccount
    {
        public BankAccount(string nameSurname, decimal initialBalance)
        {
            Owner = nameSurname;
            //initialBalance'ın transaction olarak girilmesi gerekiyor????
            MakeDeposit(initialBalance, DateTime.Now, "Hesap açılış bakiyesi.");
        }

        //protected:
        //_alTransactions field'ına bu sınıfın içerisinde ve bu sınıftan türeyen sınıflardan erişilmesini sağlar.

        protected List<Transaction> _alTransactions = new List<Transaction>();
        public string Number { get; set; } = Guid.NewGuid().ToString();
        public string? Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal b = 0;
                foreach (var item in _alTransactions)
                {
                    b += item.Amount;
                }
                return b;
            }
        }

        //Para Yatırma 
        public void MakeDeposit(decimal amt, DateTime dt, string nt)
        {
            if (amt <= 0)
            {
                throw new Exception("Yatırılan tutar 0 dan büyük olmalıdır.");
            }
            //yeni bir transation oluşturmak gerekiyor.
            var deposit = new Transaction(amt, dt, nt);
            _alTransactions.Add(deposit);
        }

        //Para Çekme

        public virtual void WithDrawal(decimal amt, DateTime dt, string nt)
        {
            if (amt <= 0)
            {
                throw new Exception("Çekilen tutar 0 dan büyük olmalıdır.");
            }

            if (Balance - amt <= 0)
            {
                throw new Exception($"Hesap bakiyeniz yetersiz. Çekilebilecek tutar: {Balance}");
            }

            var withdrawal = new Transaction(-amt, dt, nt);
            _alTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            int sayac = 1;

            foreach (var item in _alTransactions)
            {
                string islemTipi = item.Amount < 0 ? "Para Çekme" : "Para Yatırma";
                report.AppendLine($"{sayac}. işlem: {item.Amount} $ - {islemTipi}-{item.Date}");
                sayac++;
            }

            return report.ToString();
        }


        #region EncapsulationOrnek
        //private int _tip;

        //public int Tip
        //{
        //    get {
        //        if (_tip<100)
        //        {
        //            throw new Exception("hata");
        //        }
        //        return Tip;
        //    }
        //    set {
        //        if (value>100)
        //        {
        //            _tip = value;
        //        }
        //    }
        //}
        #endregion
    }
}
