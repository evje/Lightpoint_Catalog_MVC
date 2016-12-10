using System.Data.Entity;
using Catalog.Domain.Entities;

namespace Catalog.Domain.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }

        public DbSet<Good> Goods { get; set; }
    }

}