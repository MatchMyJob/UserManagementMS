namespace Application.DTO.Response
{
    public class ProvinceResponse
    {
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public List<CityResponse>? Cities { get; set; }

        public ProvinceResponse()
        {
            Cities = new();
        }
    }
}
