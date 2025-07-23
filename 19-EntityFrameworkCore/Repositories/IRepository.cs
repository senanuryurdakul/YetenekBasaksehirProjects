using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_EntityFrameworkCore.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void DeleteById(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
