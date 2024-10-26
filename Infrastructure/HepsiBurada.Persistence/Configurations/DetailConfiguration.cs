using Bogus;
using HepsiBurada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HepsiBurada.Persistence.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new Faker("tr");

            builder.HasData(
                // Elektriği Temsil Ediyor
                new Detail
                {
                    Id = 1,
                    Title = faker.Lorem.Sentence(1),
                    Description = faker.Lorem.Sentence(5),
                    CategoryId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                // Bilgisayarı temsil ediyor
                new Detail
                {
                    Id = 2,
                    Title = faker.Lorem.Sentence(1),
                    Description = faker.Lorem.Sentence(5),
                    CategoryId = 3,
                    IsDeleted = true,
                    CreatedDate = DateTime.Now
                },
                // Kadını Temsil Ediyor
                new Detail
                {
                    Id = 3,
                    Title = faker.Lorem.Sentence(1),
                    Description = faker.Lorem.Sentence(5),
                    CategoryId = 4,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
                );
        }
    }
}
