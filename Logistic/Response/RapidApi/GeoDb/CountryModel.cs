using System.Collections.Generic;

namespace Logistic.Response.RapidApi.GeoDb
{
    public class CountryModel
    {
        public List<CountryData> Data { get; set; }
    }

    public class CountryData
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string WikiDataId { get; set; }
    }
}
