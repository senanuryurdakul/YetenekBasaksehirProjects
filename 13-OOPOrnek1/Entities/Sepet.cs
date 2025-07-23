using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOPOrnek1.Entities
{
    public class Sepet
    {
        public Sepet()
        {
            UrunListesi = new List<Urun>();
        }
        public List<Urun>? UrunListesi { get; set; }

        public void UrunEkle(Urun urun)
        {
            //UrunListesi.Add(urun);
            //liste içerisinde eklenmek istenen ürün ile aynı isimde bir ürün var mı?
            //varsa adet güncelle
            //yoksa ekle
            bool varmi = false;
            foreach (var item in UrunListesi)
            {
                if (urun.ProductName == item.ProductName)
                {
                    varmi = true;
                    item.Quantity += urun.Quantity;
                    break;
                }
            }

            if (!varmi) {
                //yeni ürün ekle
                UrunListesi.Add(urun);
            }         
        }
    }
}
