namespace Domain.Entities
{
    public class MetaUser
    {
        public Guid UserId { get; set; }
        public int Phone { get; set; }
        public int CityId { get; set; }

        public Company CompanyObject { get; set; }
        public Applicant ApplicantObject { get; set; }
        public City CityObject { get; set; }   
    }
}
