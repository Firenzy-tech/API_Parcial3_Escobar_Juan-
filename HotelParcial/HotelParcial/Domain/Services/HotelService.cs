using HotelParcial.Domain.Interfaces;
using HotelParcial.Models;
using HotelParcial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelParcial.Domain.Services
{
    public class HotelService : IHotelService
    {
        private readonly DataBaseContext _context;
        public HotelService(DataBaseContext context) => _context = context;

        public async Task<Hotel> DeleteHotelByIdAsync(Guid id)
        {

            try
            {
                Hotel hotel = await _context.Hotels.FirstOrDefaultAsync(h => h.Id == id);
                _context.Hotels.Remove(hotel!);
                _context.SaveChanges();
                return hotel;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
           
        }

        public async Task<IEnumerable<Hotel>> GetHotelAsync(string city)
        {
            IEnumerable<Hotel> hotels = await _context.Hotels
                .Where(h => h.City!.Name == city)
                .Include(h => h.Rooms!.Where(p => p.Availability == true))
                .Include(h => h.City)
                .ToListAsync();

            return hotels;
        }

        public async Task<IEnumerable<Hotel>> GetHotelAsyncById(Guid id)
        {
            Guid idHotel = id;
            IEnumerable<Hotel> hotels = _context.Hotels
                .Where(h => h.Id == idHotel)
                .Include(h => h.Rooms!.Where(p => p.Availability == true))
                .Include(h => h.City)

                .ToList();

            return hotels;

        }

        public async Task<Hotel> GetHotelAsyncByIdForEdit(Guid id, int stars)
        {
            var hotel = await _context.Hotels
            .Include(h => h.Rooms)
            .FirstOrDefaultAsync(h => h.Id == id);
            hotel!.Stars = stars;
            await UpdataStartsHotelById(hotel!, stars);
            return hotel!;

        }
               

        public Task<Hotel> UpdataStartsHotelById(Hotel hotel, int stars)
        {
            try
            {
                hotel.ModifiedDate = DateTime.Now;
                _context.Hotels.Update(hotel);
                _context.SaveChanges();
                return Task.FromResult(hotel);

            }
            catch (Exception ex)
            {

                throw new Exception($"No se pudo actualizar el hotel {ex.Message}");
            }

        }

    }
}
