using HotelParcial.Domain.Interfaces;
using HotelParcial.Models.Entities;

namespace HotelParcial.Domain.Services
{
    public class CitiesService : ICitiesService
    {
        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await Task.FromResult(Enumerable.Empty<City>());
        }
    }
}

