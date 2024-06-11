namespace Application.DTO.Response
{
    public class ApplicantResponse
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dni { get; set; }
        public UbicationResponse Ubication { get; set; }
        public string Phone { get; set; }
        public string Linkedin { get; set; }
        public string Email { get; set; }
        public string MinimalDescription { get; set; }
        public string BirthDate { get; set; }
    }
}
