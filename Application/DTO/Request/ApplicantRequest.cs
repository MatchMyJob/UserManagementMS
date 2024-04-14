namespace Application.DTO.Request
{
    public class ApplicantRequest
    {
        public Guid UserId { get; set; }
        public int Phone { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Dni { get; set; }
        public string BirthDate { get; set; }
    }
}
