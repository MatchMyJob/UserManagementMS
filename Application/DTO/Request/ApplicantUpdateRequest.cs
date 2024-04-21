namespace Application.DTO.Request
{
    public class ApplicantUpdateRequest
    {
        public string Phone { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dni { get; set; }
        public string BirthDate { get; set; }
    }
}
