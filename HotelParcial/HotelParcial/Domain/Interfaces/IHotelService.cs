using HotelParcial.Models.Entities;

namespace HotelParcial.Domain.Interfaces
{
    public interface IHotelService
    {
        Task<IEnumerable<Hotel>> GetHotelsAsync();

        Task<Hotel> GetHotelAsyncById(int id);

        Task<Hotel> GetHotelByCityAsync(int IdCiudad);

        Task AddHotelAsync(Hotel hotel);

        Task UpdateHotelAsync(Hotel hotel);

        Task DeleteHotelAsync(int id);

    }
}
