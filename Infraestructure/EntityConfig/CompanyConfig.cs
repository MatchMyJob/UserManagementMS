using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");
            builder.HasKey(c => c.CompanyId);
            builder.Property(c => c.CompanyId)
                   .ValueGeneratedOnAdd();
            builder.Property(u => u.UserId)
                   .IsRequired();
            builder.Property(u => u.CityId)
                   .IsRequired();
            builder.Property(u => u.Phone)
                   .IsRequired();
            builder.Property(c => c.CUIT)
                   .HasMaxLength(12)
                   .IsRequired();
            builder.Property(bn => bn.BusinessName)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(a => a.Address)
                   .HasMaxLength(50);
            builder.Property(bs => bs.BusinessSector)
                   .HasMaxLength(50);
            builder.Property(w => w.Website)
                   .HasMaxLength(255);
            builder.Property(d => d.Description)
                   .HasMaxLength(500);
            builder.Property(l => l.Logo)
                   .HasMaxLength(255);

            builder.HasOne<City>(mu => mu.CityObject)
                   .WithMany(c => c.CompanyObjects)
                   .HasForeignKey(fk => fk.CityId);

            builder.HasOne<ContactInformation>(ci => ci.ContactInformationObject)
                   .WithOne(c => c.CompanyObject)
                   .HasForeignKey<ContactInformation>(fk => fk.CompanyId);
        }
    }
}
