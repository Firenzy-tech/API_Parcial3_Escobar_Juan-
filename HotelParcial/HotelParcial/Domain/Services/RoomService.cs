using HotelParcial.Domain.Interfaces;
using HotelParcial.Models;
using HotelParcial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelParcial.Domain.Services
{
    public class RoomService : IRoomService
    {
        private readonly DataBaseContext _context;
        public RoomService(DataBaseContext context) => _context = context;

        public Task<Hotel> GetHotelByIdBeAvailable(Guid idHotel)
        {
            var hotel = _context.Hotels.Where(h => h.Id == idHotel)
                           .FirstOrDefaultAsync();
            return hotel!;
        }

        public Task<Room> GetRoomByIdBeAvailable(Guid idHotel, string number)
        {
            var room = _context.Rooms.FirstOrDefaultAsync
                (r => r.HotelId == idHotel && r.Number == number);
            return room!;
        }

        
    }
}
