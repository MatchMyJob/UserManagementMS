namespace Application.DTO.Request
{
    public class ApplicantUpdateRequest
    {
        public int Phone { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Dni { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
