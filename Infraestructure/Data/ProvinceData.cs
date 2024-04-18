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
                new Province { ProvinceId = 06, Name = "Buenos Aires" },
                new Province { ProvinceId = 02, Name = "Ciudad Autónoma de Buenos Aires"},
                new Province { ProvinceId = 82, Name = "Santa Fe" },
                new Province { ProvinceId = 42, Name = "La Pampa" },
                new Province { ProvinceId = 14, Name = "Cordoba" },
                new Province { ProvinceId = 30, Name = "Entre Rios" },
                new Province { ProvinceId = 54, Name = "Misiones" },
                new Province { ProvinceId = 34, Name = "Formosa" },
                new Province { ProvinceId = 22, Name = "Chaco" },
                new Province { ProvinceId = 90, Name = "Tucuman" },
                new Province { ProvinceId = 10, Name = "Catamarca" },
                new Province { ProvinceId = 66, Name = "Salta" },
                new Province { ProvinceId = 38, Name = "Jujuy" },
                new Province { ProvinceId = 46, Name = "La Rioja" },
                new Province { ProvinceId = 70, Name = "San Juan" },
                new Province { ProvinceId = 74, Name = "San Luis" },
                new Province { ProvinceId = 50, Name = "Mendoza" },
                new Province { ProvinceId = 58, Name = "Neuquen" },
                new Province { ProvinceId = 18, Name = "Corrientes" },
                new Province { ProvinceId = 62, Name = "Rio Negro" },
                new Province { ProvinceId = 26, Name = "Chubut" },
                new Province { ProvinceId = 94, Name = "Tierra Del Fuego" }
                ); 
        }
    }
}
