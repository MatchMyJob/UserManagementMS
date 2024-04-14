namespace Domain.Entities
{
    public class Applicant
    {
        public Guid UserId { get; set; }
        public int CityId { get; set; }
        public int DNI { get; set; }
        public int Phone {  get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public bool Status { get; set; }

        public City CityObject { get; set; }
    }
}
