using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_UrunSiparisFormu
{

    /*
     Enumeration (Enum):
    Bir türdür ve genellikte gruplandırılması veya birbirine bağlı olması gereken durumlar için kullanılır. 

    Kod okunabilirliğini artırdığı için kullanırız.

    1-Durumları belirlerken (beklemede, tamamlandı, iptal edildi)
    2-Seçeneklerde : (kadın, erkek)
    3-Sabitler  : (Haftanın günleri)
     */
    enum Aylar
    {
        Ocak,
        Şubat,
        Mart,
        Nisan
    }

    enum Kategoriler:byte
    {
        Elektronik = 1,
        EvEşyaları = 2
    }
}
