using System.Collections.Generic;

namespace Logistic.Response.RapidApi.GeoDb
{
    public class CityModel
    {
        public  List<Data> Data { get; set; }
    }

    public class Data
    {
        public int Id { get; set; }
        public string WikiDataId { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Region { get; set; }
        public string RegionCode { get; set; }
    }
}
