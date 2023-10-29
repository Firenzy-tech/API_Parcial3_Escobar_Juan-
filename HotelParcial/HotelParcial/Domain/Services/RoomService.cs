using HotelParcial.Domain.Interfaces;
using HotelParcial.Models.Entities;

namespace HotelParcial.Domain.Services
{
    public class RoomService : IRoomService
    {
        public Task AddRoomAsync(Room room)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRoomAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoomAsyncById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoomByHotelAsync(int IdHotel)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoomByNumberAsync(string number)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Room>> GetRoomsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateRoomAsync(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
