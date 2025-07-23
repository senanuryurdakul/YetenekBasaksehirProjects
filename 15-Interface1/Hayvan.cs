using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface1
{
    public class Hayvan
    {
        public byte Yas { get; set; }
        public string? Renk { get; set; }
    }

    public class Kopek : Hayvan
    {
        public string? Name { get; set; }
    }

    public class Kus : Hayvan, IUcabilir
    {
        public byte KanatUzunlugu { get; set; }
        public byte UcuzHizi { get; set; }

        public string Uc()
        {
            return "Ucabilirim.";
        }
    }

    public interface IUcabilir
    {
        byte UcuzHizi { get; set; }
        string Uc();
    }
}
