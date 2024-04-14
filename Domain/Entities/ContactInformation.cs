namespace Domain.Entities
{
    public class ContactInformation
    {
        public int ContactInformationId { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone {  get; set; }
        public string Email { get; set; }

        public Company CompanyObject { get; set; }
    }
}
