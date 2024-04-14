using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");
            builder.HasKey(c => c.CountryId);
            //builder.Property(ci => ci.CountryId)
            //       .ValueGeneratedOnAdd();
            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasMany<Province>(p => p.ProvinceObjects)
                   .WithOne(c => c.CountryObject)
                   .HasForeignKey(fk => fk.CountryId);

            CountryData.SeedData(builder);
        }
    }
}
