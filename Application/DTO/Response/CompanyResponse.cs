namespace Application.DTO.Response
{
    public class CompanyResponse
    {
        public Guid CompanyId { get; set; }
        public UbicationResponse Ubication { get; set; }
        public string CUIT { get; set; }
        public string Phone { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string BusinessSector { get; set; }
        public string Website { get; set; }
        public string MinimalDescription { get; set; }
        public string Description { get; set; }
        public int WorkerQuantity { get; set; }
        public string Logo { get; set; }
        public string FrontPage { get; set; }
        public int Founded { get; set; }
    }
}
