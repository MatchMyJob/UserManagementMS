using Domain.Entities;
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
            builder.Property(d => d.DNI)
                   .IsRequired();
            builder.Property(n => n.Name)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(sn => sn.Surname)
                   .HasMaxLength(50)
                   .IsRequired();    
            builder.Property(b => b.BirthDate)
                   .IsRequired();

            builder.HasOne<MetaUser>(mu => mu.MetaUserObject)
                   .WithOne(a => a.ApplicantObject)
                   .HasForeignKey<Applicant>(fk => fk.UserId);
        }
    }
}
