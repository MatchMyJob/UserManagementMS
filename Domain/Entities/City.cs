namespace Domain.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public int ProvinceId { get; set; }
        public string Name { get; set; }

        public Province ProvinceObject { get; set; }
        public List<Company> CompanyObjects { get; set; }
        public List<Applicant> ApplicantObjects { get; set; }
    }
}
