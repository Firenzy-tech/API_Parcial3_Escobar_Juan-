using HotelParcial.Models.Entities;

namespace HotelParcial.Domain.Interfaces
{
    public interface IRoomService
    {
        Task<Room> GetRoomByIdBeAvailable(Guid idHotel, string number);
        Task<Hotel> GetHotelByIdBeAvailable(Guid idHotel);
    }
}
