namespace Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public Guid UserId { get; set; }
        public int CityId { get; set; }
        public string CUIT {  get; set; }
        public int Phone { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string BusinessSector { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }

        public ContactInformation ContactInformationObject { get; set; }
        public City CityObject { get; set; }
    }
}
