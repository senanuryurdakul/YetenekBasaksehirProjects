using _17_RepositoryMantigi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepositoryMantigi.Repositories
{
    //where T : BaseEntity  T yerine BaseEntity türünde bir sınıf verilebilir.
    //where T : class       T yerine sadece bir class verilebilir.
    public interface IRepository<T> where T : BaseEntity
    {
        //Repository'ler için bir standart oluşturmak istiyorum. Ekle, sil güncelle gibi metodları standart hale getirelim:

        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
        T GetByID(string id);
        List<T> GetAll();

    }
}
