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
            try
            {
                var hotel = await _hotelService.GetHotelAsyncById(id);
                if (hotel == null)
                {
                    return NotFound();
                }
                return Ok(hotel);
            }
            catch (Exception ex)
            {

                throw new Exception($"No se pudo consultar los hoteles {ex.Message}");
            }
        }


        [HttpGet, ActionName("Get")]
        [Route("GetHotelByCity")]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotelFree(string city)
        {

            try
            {
                var rooms = await _hotelService.GetHotelAsync(city);
                if (rooms == null)
                {
                    return NotFound();
                }
                return Ok(rooms);
            }
            catch (Exception ex)
            {

                throw new Exception($"No se pudo realizar la consulta {ex.Message }");
            }

        }

        [HttpPost, ActionName("Post")]
        [Route("updateStartsById")]
        public async Task<ActionResult<Hotel>> updateStartsById(Guid id, int starts)
        {
            try
            {
                Hotel hotel = await _hotelService.GetHotelAsyncByIdForEdit(id, starts);
                return Ok($"Se ha actualizado las estrellas del hotel: {hotel.Name}, nueva calificación: {hotel.Stars} estrellas");
            }
            catch (Exception ex)
            {

                throw new Exception($"No se pudo actualizar el hotel {ex.Message}");

            }

        }


        [HttpDelete, ActionName("Delete")]
        [Route("DeleteHotelById")]

        public async Task<ActionResult<Hotel>> DeleteHotelById(Guid id)
        {
            var hotel = await _hotelService.DeleteHotelByIdAsync(id);
            return Ok($"Se ha eliminado correctamente el Hotel:{hotel.Name}, con id: {hotel.Id}");
        }


    }
}
