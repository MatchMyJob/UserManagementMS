using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class ContactInformationConfig : IEntityTypeConfiguration<ContactInformation>
    {
        public void Configure(EntityTypeBuilder<ContactInformation> builder)
        {
            builder.ToTable("ConctacInformation");
            builder.HasKey(c => c.ContactInformationId);
            builder.Property(c => c.ContactInformationId)
                   .ValueGeneratedOnAdd();
            builder.HasIndex(u => u.CompanyId)
                   .IsUnique();
            builder.Property(n => n.Name)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(s => s.Surname)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(p => p.Phone)
                   .HasMaxLength(15)
                   .IsRequired();
            builder.Property(e => e.Email)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.HasOne<Company>(c => c.CompanyObject)
                   .WithOne(ci => ci.ContactInformationObject)
                   .HasForeignKey<ContactInformation>(ci => ci.CompanyId);
        }

    }
}
