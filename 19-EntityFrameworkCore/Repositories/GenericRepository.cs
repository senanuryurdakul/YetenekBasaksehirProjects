using _19_EntityFrameworkCore.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_EntityFrameworkCore.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet=_context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            _dbSet.Remove(GetById(id));
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            var find = _dbSet.Find(id);
            if (find!=null)
            {
                return find;
            }
            else
            {
                throw new Exception("Bulunamadı");
            }
        }

        public void Update(T entity)
        {
            _context.SaveChanges();
        }
    }
}
