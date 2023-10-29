using HotelParcial.Domain.Interfaces;
using HotelParcial.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HotelParcial.Controllers
{
    [ApiController]
    [Display(Name = "Registro general Hoteles")]
    [Route("api/[controller]")]
    public class SearchController : Controller
    {

        private readonly IConsultaService _citiesService;

        public SearchController(IConsultaService citiesService)
        {
            _citiesService = citiesService;
        }

        [HttpGet, ActionName("Get")]
        [Route("GetAllHotelStatus")]
        public async Task<ActionResult<IEnumerable<Country>>> GetCities()
        {
            try
            {
                var countries = await _citiesService.GetAllAboutHotelAsync();
                return Ok(countries);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet, ActionName("get")]
        [Route("GetHotelFree")]

        public async Task<ActionResult<IEnumerable<Room>>> GetHotelFree()
        {

            try
            {
                var rooms = await _citiesService.GetHotelFreeAsync();
                return Ok(rooms);
            }
            catch (Exception ex)
            {

                throw;
            }

        }



    }
}
