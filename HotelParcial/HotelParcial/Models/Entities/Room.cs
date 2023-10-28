using System.ComponentModel.DataAnnotations;

namespace HotelParcial.Models.Entities
{
    public class Room : AuditBase
    {

        [Display(Name = "Numero de habitación")]
        [MaxLength(10)]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Number { get; set; }

        [Display(Name = "Capacidad de personas ")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int MaxGuests { get; set; }

        [Display(Name = "Estado de la habitación")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public bool Availability { get; set; }

        [Display(Name = "Id Hotel")]
        public int HotelId { get; set; }
    }
}
