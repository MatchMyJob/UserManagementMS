﻿namespace Application.DTO.Request
{
    public class CompanyRequest
    {
        public Guid UserId { get; set; }
        public int Phone {  get; set; }
        public int CityId { get; set; }
        public string Cuit {  get; set; }
        public string BusinessName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string BusinessSector { get; set; }
        public string WebSite { get; set; }
        public string Logo { get; set; }
    }
}
