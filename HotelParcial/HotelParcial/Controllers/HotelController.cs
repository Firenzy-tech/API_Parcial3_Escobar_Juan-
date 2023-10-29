using HotelParcial.Domain.Interfaces;
using HotelParcial.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelParcial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : Controller
    {

        public readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;

        }

        [HttpGet, ActionName("Get")]
        [Route("GetHotelById")]

        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotelById(Guid id)
        {
            var hotel = await _hotelService.GetHotelAsyncById(id);
            return Ok(hotel);
        }


        [HttpGet, ActionName("Get")]
        [Route("GetHotelByCity")]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotelFree(string city)
        {

            var rooms = await _hotelService.GetHotelAsync(city);
            return Ok(rooms);

        }

        [HttpPost, ActionName("Post")]
        [Route("updateStartsById")]
        public async Task<ActionResult<Hotel>> updateStartsById(Guid id, int starts)
        {
            Hotel hotel = await _hotelService.GetHotelAsyncByIdForEdit(id, starts);

            
            return Ok(hotel);

        }


        [HttpDelete, ActionName("Delete")]
        [Route("DeleteHotelById")]

        public async Task<ActionResult<Hotel>> DeleteHotelById(Guid id)
        {
            var hotel = await _hotelService.DeleteHotelByIdAsync(id);
            return Ok(hotel);
        }


    }
}
