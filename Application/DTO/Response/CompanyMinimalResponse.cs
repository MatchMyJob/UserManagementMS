namespace Application.DTO.Response
{
    public class CompanyMinimalResponse
    {
        public Guid CompanyId { get; set; }
        public UbicationResponse Ubication { get; set; }
        public string BusinessName { get; set; }
        public string BusinessSector { get; set; }
        public string MinimalDescription { get; set; }
        public string Logo { get; set; }
    }
}
