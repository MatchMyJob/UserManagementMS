namespace Application.DTO.Response
{
    public class ApplicantResponse
    {
        public Guid UserId { get; set; }
        public int Phone { get; set; }
        public CityResponse City { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Dni { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
