namespace Application.DTO.Response
{
    public class CompanyGetResponse
    {
        public int CompanyId { get; set; }
        public UbicationResponse Ubication { get; set; }
        public string Phone {  get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string BusinessSector { get; set; }
        public string WebSite { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
    }
}
