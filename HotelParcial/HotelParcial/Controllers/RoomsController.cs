using HotelParcial.Domain.Interfaces;
using HotelParcial.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelParcial.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController: Controller
    {

        public readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
                _roomService = roomService;
        }

        [HttpGet, ActionName("Get")]
        [Route("GetRoomByIdAvailable")]
        public async Task<ActionResult<IEnumerable<Room>>> GetRoomByIdAvailableStatus(Guid idHotel, string number )
        {
            try
            {
                Room? room = await _roomService.GetRoomByIdBeAvailable(idHotel, number);
                if(room == null)
                {
                    return Ok($"No existe la habitacion con numero: {number} del hotel id:{idHotel}");
                }
                var nameHotel = await _roomService.GetHotelByIdBeAvailable(idHotel);
                if (room!.Availability == false || room! == null)
                {
                    return Ok($"No se encuentra disponibilidad para la habitacion con numero: {number} del hotel id:{nameHotel.Name}");
                }

                Room responseRoom = new()
                {
                    Id = room.Id,
                    Number = room.Number,
                    HotelId = room.HotelId,
                    Availability = room.Availability,
                    Price = room.Price,

                };
                return Ok(responseRoom);
            }
            catch (Exception ex)
            {

                throw new Exception($"No se pudo consultar los hoteles {ex.Message}");
            }
        }




    }
}
