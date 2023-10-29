using System.ComponentModel.DataAnnotations;

namespace HotelParcial.Models.Entities
{
    public class City: AuditBase
    {
        
        [Display(Name = "Id Estado")]
        public Guid StateId { get; set; } 

        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Required(ErrorMessage = "¡El campo {0} es obligatorio!")]
        public string Name { get; set; }
        public ICollection<Hotel>? Hotels { get; set; }

        public State? State { get; set; }

    }
}
