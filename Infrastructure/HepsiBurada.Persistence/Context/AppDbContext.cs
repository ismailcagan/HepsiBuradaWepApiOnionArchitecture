using HepsiBurada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HepsiBurada.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(){}
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
