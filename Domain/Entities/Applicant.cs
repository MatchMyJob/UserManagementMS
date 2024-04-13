namespace Domain.Entities
{
    public class Applicant
    {
        public Guid UserId { get; set; }
        public int DNI { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public MetaUser MetaUserObject { get; set; }
    }
}
