using System.ComponentModel.DataAnnotations;

namespace HotelParcial.Models.Entities
{
    public class Hotel : AuditBase
    {

        [Display(Name = "Nombre del hotel")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }

        [Display(Name = "País del hotel")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El país es requerido")]
        public string Coutry { get; set; }

        [Display(Name = "Ciudad del hotel")]
        [MaxLength(50)]
        [Required(ErrorMessage = "La ciudad es requerida")]
        public string City { get; set; }

        [Display(Name = "Dirección del hotel")]
        [MaxLength(50)]
        [Required(ErrorMessage = "La dirección es requerida")]
        public string Address { get; set; }

        [Display(Name = "Teléfono del hotel")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El teléfono es requerido")]
        public string Phone { get; set; }

        [Display(Name = "Estrellas del hotel")]
        [Required(ErrorMessage = "Las estrellas son requeridas")]
        public string PostalCode { get; set; }
        public int Stars { get; set; }

        [Display(Name = "Descripción del hotel")]
        [MaxLength(50)]
        [Required(ErrorMessage = "La descripción es requerida")]
        public ICollection<Room>? Rooms { get; set; }
    }
}
