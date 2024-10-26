using HepsiBurada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HepsiBurada.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Category değerleri verildi
            builder.HasData(
                new Category() { Id = 1, Name = "Elektrik", Priorty = 1, ParendId = 0, IsDeleted = false, CreatedDate = DateTime.Now },
                new Category() { Id = 2, Name = "Moda", Priorty = 2, ParendId = 0, IsDeleted = false, CreatedDate = DateTime.Now }
                );
            // Parenlarını yani alt categoriler verildi.(ParenId ler Categori Id leri ile aynı değerler verildi.)
            builder.HasData(
                new Category { Id = 3, Name = "Bilgisayar", Priorty = 1, ParendId = 1, IsDeleted = false, CreatedDate = DateTime.Now },
                new Category { Id = 4, Name = "Kadın", Priorty = 1, ParendId = 2, IsDeleted = false, CreatedDate = DateTime.Now }
                );
        }
    }
}
