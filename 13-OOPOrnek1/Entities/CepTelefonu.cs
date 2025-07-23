using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOPOrnek1.Entities
{
    public class CepTelefonu : Urun
    {
        public byte BatteryLife { get; set; }
        public byte RamCapacity { get; set; }
        public string? CpuModel { get; set; }

        public override double KdvHesapla()
        {
            return UnitPrice * 1.20;
        }
    }
}
