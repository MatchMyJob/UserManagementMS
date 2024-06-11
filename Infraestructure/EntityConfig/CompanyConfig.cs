using Domain.Entities;
using Infraestructure.Data;
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
            builder.HasIndex(c => c.CompanyId)
                   .IsUnique();
            builder.Property(u => u.CityId)
                   .IsRequired();
            builder.Property(u => u.Phone)
                   .HasMaxLength(15)
                   .IsRequired();
            builder.Property(c => c.CUIT)
                   .HasMaxLength(14)
                   .IsRequired();
            builder.Property(bn => bn.BusinessName)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(a => a.Address)
                   .HasMaxLength(50)
                   .IsRequired(false);
            builder.Property(bs => bs.BusinessSector)
                   .HasMaxLength(50);
            builder.Property(w => w.Website)
                   .HasMaxLength(255);
            builder.Property(w => w.MinimalDescription)
                   .HasMaxLength(255);
            builder.Property(d => d.Description)
                   .HasMaxLength(2000);
            builder.Property(w => w.WorkerQuantity)
                   .IsRequired();
            builder.Property(l => l.Logo)
                   .HasMaxLength(255);
            builder.Property(l => l.FrontPage)
                   .HasMaxLength(255);
            builder.Property(l => l.Founded)
                   .IsRequired();

            builder.HasOne<City>(mu => mu.CityObject)
                   .WithMany(c => c.CompanyObjects)
                   .HasForeignKey(fk => fk.CityId);

            builder.HasOne<ContactInformation>(ci => ci.ContactInformationObject)
                   .WithOne(c => c.CompanyObject)
                   .HasForeignKey<ContactInformation>(fk => fk.CompanyId);

            CompanyData.SeedData(builder);
        }
    }
}
