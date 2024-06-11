using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class ApplicantConfig : IEntityTypeConfiguration<Applicant>
    {
        public void Configure(EntityTypeBuilder<Applicant> builder)
        {
            builder.ToTable("Applicant");
            builder.HasKey(a => a.UserId);
            builder.Property(a => a.UserId)
                   .IsRequired();
            builder.Property(u => u.CityId)
                   .IsRequired();
            builder.Property(u => u.Phone)
                   .IsRequired();
            builder.Property(d => d.DNI)
                   .IsRequired();
            builder.HasIndex(d => d.DNI)
                    .IsUnique();
            builder.Property(n => n.Name)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(sn => sn.Surname)
                   .HasMaxLength(50)
                   .IsRequired();    
            builder.Property(b => b.BirthDate)
                   .IsRequired();

            builder.HasOne<City>(mu => mu.CityObject)
                    .WithMany(c => c.ApplicantObjects)
                    .HasForeignKey(fk => fk.CityId);

            ApplicantData.SeedData(builder);
        }
    }
}
