using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class MetaUserConfig : IEntityTypeConfiguration<MetaUser>
    {
        public void Configure(EntityTypeBuilder<MetaUser> builder)
        {
            builder.ToTable("MetaUser");
            builder.HasKey(mu => mu.UserId);
            builder.Property(u => u.UserId).
                   IsRequired();
            builder.Property(ci => ci.CityId)
                   .IsRequired();
            builder.Property(p => p.Phone)
                   .IsRequired();

            builder.HasOne<City>(c => c.CityObject)
                   .WithMany(us => us.MetaUserObjects)
                   .HasForeignKey(fk => fk.CityId);

            builder.HasOne<Company>(c => c.CompanyObject)
                   .WithOne(u => u.MetaUserObject)
                   .HasForeignKey<Company>(fk => fk.UserId);

            builder.HasOne<Applicant>(a => a.ApplicantObject)
                   .WithOne(u => u.MetaUserObject)
                   .HasForeignKey<Applicant>(fk => fk.UserId);
        }
    }
}
