using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");
            builder.HasKey(c => c.CityId);
            //builder.Property(c => c.CityId)
            //       .ValueGeneratedOnAdd();
            builder.Property(p => p.ProvinceId)
                   .IsRequired();
            builder.Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasOne<Province>(c => c.ProvinceObject)
                   .WithMany(c => c.CityObjects)
                   .HasForeignKey(c => c.ProvinceId);

            builder.HasMany<Company>(c => c.CompanyObjects)
                   .WithOne(c => c.CityObject)
                   .HasForeignKey(fk => fk.CityId);

            builder.HasMany<Applicant>(a => a.ApplicantObjects)
                   .WithOne(c => c.CityObject)
                   .HasForeignKey(fk => fk.CityId);

            CityData.SeedData(builder);
        }
    }
}
