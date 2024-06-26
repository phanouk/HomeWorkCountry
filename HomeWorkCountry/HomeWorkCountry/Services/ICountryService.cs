using HomeWorkCountry.Models;

namespace HomeWorkCountry.Services
{
    public interface ICountryService
    {
        Task<CountryInfo> GetCountryByNameAsync(string countryName);
        Task<IEnumerable<CountryInfo>> GetCountriesByAreaAsync(string region, string timezones);
    }
}