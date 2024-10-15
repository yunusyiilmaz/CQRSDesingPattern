using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CQRSDesingPattern.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("ConnectionString");
        }
        public DbSet<Product> Products { get; set; }
    }
}
