using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace HomeWorkCountry.Models
{
    public class CountryByNameRequest
    {
        public string CountryByName { get; set; }
    }
    public class CountryInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("alpha2Code")]
        public string Alpha2Code { get; set; }

        [JsonPropertyName("capital")]
        public string Capital { get; set; }

        [JsonPropertyName("callingCodes")]
        public List<string> CallingCodes { get; set; }

        [JsonPropertyName("flag")]
        public string FlagUrl { get; set; }

        [JsonPropertyName("timezones")]
        public List<string> Timezones { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }
    }
}
