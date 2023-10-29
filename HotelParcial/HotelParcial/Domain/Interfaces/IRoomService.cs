using HotelParcial.Models.Entities;

namespace HotelParcial.Domain.Interfaces
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetRoomsAsync();

        Task<Room> GetRoomAsyncById(int id);

        Task<Room> GetRoomByNumberAsync(string number);

        Task<Room> GetRoomByHotelAsync(int IdHotel);

        Task AddRoomAsync(Room room);

        Task UpdateRoomAsync(Room room);

        Task DeleteRoomAsync(int id);
    }
}
