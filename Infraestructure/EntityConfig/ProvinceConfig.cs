using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class ProvinceConfig : IEntityTypeConfiguration<Province>

    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("Province");
            builder.HasKey(p => p.ProvinceId);
            builder.Property(pi => pi.ProvinceId)
                   .ValueGeneratedOnAdd();
            builder.Property(c => c.CountryId)
                   .IsRequired();
            builder.Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasOne<Country>(c => c.CountryObject)
                   .WithMany(ps => ps.ProvinceObjects)
                   .HasForeignKey(fk => fk.CountryId);

            builder.HasMany<City>(cs => cs.CityObjects)
                   .WithOne(p => p.ProvinciaObject)
                   .HasForeignKey(fk => fk.ProvinceId);
        }
    }
}
