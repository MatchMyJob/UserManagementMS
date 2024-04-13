namespace Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public Guid UserId { get; set; }
        public string CUIT {  get; set; }

        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string BusinessSector { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public MetaUser MetaUserObject { get; set; }
        public ContactInformation ContactInformationObject { get; set; }   

    }
}
