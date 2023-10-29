using HotelParcial.Domain.Interfaces;
using HotelParcial.Models;
using HotelParcial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelParcial.Domain.Services
{
    public class CitiesService : IGeneralService
    {
        private readonly DataBaseContext _context;

        public CitiesService(DataBaseContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Country>> HotelFreeAsync => throw new NotImplementedException();

        public async Task<IEnumerable<Country>> GetAllAboutHotelAsync()
        {

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            var countries = await _context.Countries
                .Include(c => c.States)
                .ThenInclude(s => s.Cities)
                .ThenInclude(c => c.Hotels)
                .ThenInclude(h => h.Rooms)
                .ToListAsync();
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            return countries;
        }

        public async Task<IEnumerable<Room>> GetHotelFreeAsync()
        {
            IEnumerable<Room> rooms = await _context.Rooms.FirstOrDefaultAsync(r => r.Availability == true) as IEnumerable<Room>;
            return rooms.;

            
        }
    }
}

