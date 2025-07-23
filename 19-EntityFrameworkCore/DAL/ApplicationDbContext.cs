using _19_EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace _19_EntityFrameworkCore.DAL
{
    public class ApplicationDbContext:DbContext
    {
        //Db'deki tablolarımızı belirleyeceğimiz alan.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Course;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CanerEticaretDB;Integrated Security=True;");   
        }
    }
}
