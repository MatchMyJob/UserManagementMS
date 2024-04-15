namespace Application.DTO.Request
{
    public class ContactInformationRequest
    {
        public int CompanyId { get; set; }
        public string Name {  get; set; }
        public string Surname { get; set; }
        public int Phone {  get; set; }
        public string Email { get; set; }
    }
}
