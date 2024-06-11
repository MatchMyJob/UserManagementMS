namespace Domain.Entities
{
    public class ContactInformation
    {
        public int ContactInformationId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }

        public Company CompanyObject { get; set; }
    }
}
