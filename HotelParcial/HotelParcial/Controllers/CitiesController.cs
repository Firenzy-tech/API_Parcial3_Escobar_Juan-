using HotelParcial.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelParcial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController:Controller
    {

        private readonly ICitiesService _citiesService;

        public CitiesController(ICitiesService citiesService)
        {
                _citiesService =  citiesService;
        }

        [HttpGet, ActionName("Get")]
        [Route("GetCities")]
        public async Task<IActionResult> GetCities()
        {
            var cities = await _citiesService.GetCitiesAsync();
            return Ok(cities);
        }

    }
}
