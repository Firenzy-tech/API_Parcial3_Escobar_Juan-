using HotelParcial.Models.Entities;

namespace HotelParcial.Domain.Interfaces
{
    public interface ICitiesService
    {
        Task<IEnumerable<City>> GetCitiesAsync();    
    }
}
