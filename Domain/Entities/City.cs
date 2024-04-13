using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public int ProvinceId { get; set; }
        public string Name { get; set; }

        public Province ProvinciaObject { get; set; }
        public List<MetaUser> MetaUserObjects { get; set; }
    }
}
