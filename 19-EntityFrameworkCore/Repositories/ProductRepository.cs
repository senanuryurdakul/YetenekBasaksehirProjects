using _19_EntityFrameworkCore.DAL;
using _19_EntityFrameworkCore.Entities;

namespace _19_EntityFrameworkCore.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
