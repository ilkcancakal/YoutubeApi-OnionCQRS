using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(256);

            Faker faker = new("tr");

            Category category1 = new()
            {
                Id = 1,
                Name = "Elektrik",
                ParentId = 0,
                Priority = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };

            Category category2 = new()
            {
                Id = 2,
                Name = "Moda",
                ParentId = 0,
                Priority = 2,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };

            Category parent1 = new()
            {
                Id = 3,
                Name = "Kadin",
                ParentId = 2,
                Priority = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };

            Category parent2 = new()
            {
                Id = 4,
                Name = "Bilgisayar",
                ParentId = 1,
                Priority = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };

            builder.HasData(category1, category2, parent1, parent2);
        }
    }
}
