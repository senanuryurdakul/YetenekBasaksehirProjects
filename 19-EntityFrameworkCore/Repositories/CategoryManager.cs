using _19_EntityFrameworkCore.Entities;
using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_EntityFrameworkCore.Repositories
{
    public class CategoryManager : IRepository<Category>
    {
        private readonly CategoryRepository _repository;
        public CategoryManager(CategoryRepository cRepo)
        {
            _repository = cRepo;
        }
        public void Add(Category entity)
        {
            if (entity != null)
            {
                _repository.Add(entity);
            }
        }

        public void DeleteById(int id)
        {
            _repository.DeleteById(id);
        }

        public List<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public Category GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(Category entity)
        {
            _repository.Update(entity);
        }
    }
}
