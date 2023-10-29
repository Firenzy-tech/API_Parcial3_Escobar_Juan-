using HotelParcial.Domain.Interfaces;
using HotelParcial.Models.Entities;

namespace HotelParcial.Domain.Services
{
    public class HotelService : IHotelService
    {
        public Task AddHotelAsync(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHotelAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> GetHotelAsyncById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> GetHotelByCityAsync(int IdCiudad)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hotel>> GetHotelsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateHotelAsync(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
