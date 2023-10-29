using HotelParcial.Models.Entities;

namespace HotelParcial.Domain.Interfaces
{
    public interface IConsultaService
    {
        Task<IEnumerable<Country>> GetAllAboutHotelAsync();
        Task<IEnumerable<Country>> HotelFreeAsync { get; }
        Task<IEnumerable<Room>> GetHotelFreeAsync();
    }
}
