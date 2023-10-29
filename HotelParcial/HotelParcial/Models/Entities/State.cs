using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace HotelParcial.Models.Entities
{
    public class State : AuditBase
    {
        [Display(Name = "Estado/Departamento")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Required(ErrorMessage = "¡El campo {0} es obligatorio!")]
        public string Name { get; set; }

        [Display(Name = "País")]
        //Relación con Country


     
        public Guid CountryId { get; set; } //FK

        public ICollection<City>? Cities { get; set; }

        public Country? Country { get; set; }
    }
}
