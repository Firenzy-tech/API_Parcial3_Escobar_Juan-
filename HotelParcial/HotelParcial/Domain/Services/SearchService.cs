using HotelParcial.Domain.Interfaces;
using HotelParcial.Models;
using HotelParcial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelParcial.Domain.Services
{
    public class SearchService : IConsultaService
    {
        private readonly DataBaseContext _context;

        public SearchService(DataBaseContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Country>> HotelFreeAsync => throw new NotImplementedException();

        public async Task<IEnumerable<Country>> GetAllAboutHotelAsync()
        {

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            IEnumerable<Country> countries = await _context.Countries
                .Include(c => c.States!.Where(p=> p.Id == p.CountryId))
                .ThenInclude(s => s.Cities!.Where(p => p.Id == p.StateId))
                .ThenInclude(c => c.Hotels!.Where(p=> p.Id == p.CityId))
                .ThenInclude(h => h.Rooms!.Where(p => p.Id == p.HotelId))
                .ToListAsync();
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            return countries;
        }

        public async Task<IEnumerable<Room>> GetHotelFreeAsync()
        {
            IEnumerable<Room> rooms = await _context.Rooms
                .Where(r => r.Availability == true)
                .Include(r => r.Hotel).Where(p => p.Hotel!.Id == p.HotelId)
                .Include(r => r.Hotel!.City).Where(p => p.Hotel!.City!.Id == p.Hotel!.CityId)
                .Include(r => r.Hotel!.City!.State).Where(p => p.Hotel!.City!.State!.Id == p.Hotel!.City!.StateId).IgnoreQueryFilters()
                .ToListAsync();
            return rooms;
        }
    }
}

