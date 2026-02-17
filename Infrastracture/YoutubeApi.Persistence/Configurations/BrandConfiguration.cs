using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(256);

            Faker faker = new("tr");

            builder.HasData(
                new Brand { Id = 1, Name = faker.Company.CompanyName(), CreatedDate = DateTime.Now, IsDeleted = false },
                new Brand { Id = 2, Name = faker.Company.CompanyName(), CreatedDate = DateTime.Now, IsDeleted = false },
                new Brand { Id = 3, Name = faker.Company.CompanyName(), CreatedDate = DateTime.Now, IsDeleted = false },
                new Brand { Id = 4, Name = faker.Company.CompanyName(), CreatedDate = DateTime.Now, IsDeleted = false },
                new Brand { Id = 5, Name = faker.Company.CompanyName(), CreatedDate = DateTime.Now, IsDeleted = true }
            );
        }
    }
}
