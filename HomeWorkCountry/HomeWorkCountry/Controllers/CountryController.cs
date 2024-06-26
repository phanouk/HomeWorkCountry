using HomeWorkCountry.Models;
using HomeWorkCountry.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeWorkCountry.Controllers
{
    [ApiController]
    [Route("api")]
    public class CountryController :ControllerBase
    {
        private readonly ICountryService _countryService;
        
        public CountryController(ICountryService countryService)
        {
              _countryService = countryService; 
        }

        [HttpPost("Country/GetCountryByName")]
        public async Task<ActionResult<CountryInfo>> GetCountryByName([FromBody] CountryByNameRequest request)
        {
            var country = await _countryService.GetCountryByNameAsync(request.CountryByName);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost("Country/GetCountryByArea")]
        public async Task<ActionResult<IEnumerable<CountryInfo>>> GetCountryByArea([FromBody] AreaInfo request)
        {
            var countries = await _countryService.GetCountriesByAreaAsync(request.Region, request.Timezones);
            return Ok(countries);
        }

    }
}
