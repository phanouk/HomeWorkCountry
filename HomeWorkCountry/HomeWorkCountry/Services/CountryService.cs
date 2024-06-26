using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using HomeWorkCountry.Models;
using HomeWorkCountry.Services;

public class CountryService : ICountryService
{
    private readonly HttpClient _httpClient;

    public CountryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CountryInfo> GetCountryByNameAsync(string countryName)
    {
        var response = await _httpClient.GetAsync($"https://restcountries.com/v2/name/{countryName}");
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        var countries = JsonSerializer.Deserialize<List<CountryInfo>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return countries?.FirstOrDefault();
    }

    public async Task<IEnumerable<CountryInfo>> GetCountriesByAreaAsync(string region, string timezones)
    {
        var response = await _httpClient.GetAsync("https://restcountries.com/v2/all");
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        var countries = JsonSerializer.Deserialize<List<CountryInfo>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return countries?.Where(c => c.Region == region && c.Timezones.Contains(timezones));
    }
}
