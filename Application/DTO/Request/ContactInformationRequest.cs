namespace Application.DTO.Request
{
    public class ContactInformationRequest
    {
        public Guid CompanyId { get; set; }
        public string Name {  get; set; }
        public string Surname { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
    }
}
