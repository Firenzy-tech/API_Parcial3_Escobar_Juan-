using HotelParcial.Models.Entities;

namespace HotelParcial.Domain.Interfaces
{
    public interface IHotelService
    {
        Task<IEnumerable<Hotel>> GetHotelAsyncById(Guid id);
        Task<Hotel> GetHotelAsyncByIdForEdit(Guid id, int starts);
        Task<IEnumerable<Hotel>> GetHotelAsync(string city);
        Task<Hotel> UpdataStartsHotelById(Hotel hotel, int starts);


    }
}
