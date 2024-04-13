using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public class CityData : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City { CityId = 1, Name = "Barracas", ProvinceId = 1 },
                new City { CityId = 2, Name = "Puerto Madero", ProvinceId = 1 },
                new City { CityId = 3, Name = "Esperanza", ProvinceId = 2 },
                new City { CityId = 4, Name = "Rosario", ProvinceId = 2 },
                new City { CityId = 5, Name = "Arata", ProvinceId = 3 },
                new City { CityId = 6, Name = "Bernasconi", ProvinceId = 3 },
                new City { CityId = 7, Name = "Rio Cuarto", ProvinceId = 4 },
                new City { CityId = 8, Name = "Mina Clavero", ProvinceId = 4 },
                new City { CityId = 9, Name = "Gualeguaychú", ProvinceId = 5 },
                new City { CityId = 10, Name = "Diamante", ProvinceId = 5 },
                new City { CityId = 11, Name = "Posadas", ProvinceId = 6 },
                new City { CityId = 12, Name = "Puerto Libertad", ProvinceId = 6 },
                new City { CityId = 13, Name = "El Colorado", ProvinceId = 7 },
                new City { CityId = 14, Name = "Clorinda", ProvinceId = 7 },
                new City { CityId = 15, Name = "Resistencia", ProvinceId = 8 },
                new City { CityId = 16, Name = "Chorotis", ProvinceId = 8 },
                new City { CityId = 17, Name = "Moreno", ProvinceId = 9 },
                new City { CityId = 18, Name = "Alberdi", ProvinceId = 9 },
                new City { CityId = 19, Name = "Tafí del valle", ProvinceId = 10 },
                new City { CityId = 20, Name = "Villa Nougues", ProvinceId = 10 },
                new City { CityId = 21, Name = "Aconquija", ProvinceId = 11 },
                new City { CityId = 22, Name = "Belén", ProvinceId = 11 },
                new City { CityId = 23, Name = "Orán", ProvinceId = 12 },
                new City { CityId = 24, Name = "Cachi", ProvinceId = 12 },
                new City { CityId = 25, Name = "La Quiaca", ProvinceId = 13 },
                new City { CityId = 26, Name = "Purmamarca", ProvinceId = 13 },
                new City { CityId = 27, Name = "Briones", ProvinceId = 14 },
                new City { CityId = 28, Name = "Ezcaray", ProvinceId = 14 },
                new City { CityId = 29, Name = "Chimbas", ProvinceId = 15 },
                new City { CityId = 30, Name = "Caucete", ProvinceId = 15 },
                new City { CityId = 31, Name = "Villa Mercedes", ProvinceId = 16 },
                new City { CityId = 32, Name = "Villa Merlo", ProvinceId = 16 },
                new City { CityId = 33, Name = "Guaymallen", ProvinceId = 17 },
                new City { CityId = 34, Name = "San Rafael", ProvinceId = 17 },
                new City { CityId = 35, Name = "Villa La Angostura", ProvinceId = 18 },
                new City { CityId = 36, Name = "San Martín de los Andes", ProvinceId = 18 },
                new City { CityId = 37, Name = "El Bolson", ProvinceId = 19 },
                new City { CityId = 38, Name = "San Carlos de Bariloche", ProvinceId = 19 },
                new City { CityId = 39, Name = "Viedma", ProvinceId = 20 },
                new City { CityId = 40, Name = "Chimpay", ProvinceId = 20 },
                new City { CityId = 41, Name = "Esquel", ProvinceId = 21 },
                new City { CityId = 42, Name = "Puerto Madryn", ProvinceId = 21 },
                new City { CityId = 43, Name = "Rio Gallegos", ProvinceId = 22 },
                new City { CityId = 44, Name = "Perito Moreno", ProvinceId = 22 },
                new City { CityId = 45, Name = "Ushuaia", ProvinceId = 23 },
                new City { CityId = 46, Name = "Rio Grande", ProvinceId = 23 }

                );
        }
    }
}
