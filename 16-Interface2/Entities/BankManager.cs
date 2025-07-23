using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interface2.Entities
{
    public class BankManager
    {
        IBankManager _bankmanager;
        public BankManager(IBankManager gb)
        {
            _bankmanager = gb;
        }
        public string Ekle()
        {
           return _bankmanager.AddTransaction();
        }

        public string Sil(int id)
        {
           return _bankmanager.DeleteTransaction(id);
        }

        public string Guncelle(int id)
        {
           return _bankmanager.UpdateTransaction(id);
        }
    }
}
