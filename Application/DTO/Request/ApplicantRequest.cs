namespace Application.DTO.Request
{
    public class ApplicantRequest
    {
        public int CityId { get; set; }
        public string DNI { get; set; }
        public string Phone {  get; set; }
        public string Linkedin { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MinimalDescription { get; set; }
        public string BirthDate { get; set; }
    }
}
