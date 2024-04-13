using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public class ProvinceData : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasData(
                new Province { ProvinceId = 1, Name = "Buenos Aires"},
                new Province { ProvinceId = 2, Name = "Santa Fe" },
                new Province { ProvinceId = 3, Name = "La Pampa" },
                new Province { ProvinceId = 4, Name = "Cordoba" },
                new Province { ProvinceId = 5, Name = "Entre Rios" },
                new Province { ProvinceId = 6, Name = "Misiones" },
                new Province { ProvinceId = 7, Name = "Formosa" },
                new Province { ProvinceId = 8, Name = "Chaco" },
                new Province { ProvinceId = 9, Name = "Santiago Del Estero" },
                new Province { ProvinceId = 10, Name = "Tucuman" },
                new Province { ProvinceId = 11, Name = "Catamarca" },
                new Province { ProvinceId = 12, Name = "Salta" },
                new Province { ProvinceId = 13, Name = "Jujuy" },
                new Province { ProvinceId = 14, Name = "La Rioja" },
                new Province { ProvinceId = 15, Name = "San Juan" },
                new Province { ProvinceId = 16, Name = "San Luis" },
                new Province { ProvinceId = 17, Name = "Mendoza" },
                new Province { ProvinceId = 18, Name = "Neuquen" },
                new Province { ProvinceId = 19, Name = "Bariloche" },
                new Province { ProvinceId = 20, Name = "Rio Negro" },
                new Province { ProvinceId = 21, Name = "Chubut" },
                new Province { ProvinceId = 22, Name = "Santa Cruz" },
                new Province { ProvinceId = 23, Name = "Tierra Del Fuego" }
                );
        }
    }
}
