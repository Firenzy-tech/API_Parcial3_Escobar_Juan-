using System.ComponentModel.DataAnnotations;

namespace HotelParcial.Models.Entities
{
    public class Hotel : AuditBase
    {

        [Display(Name = "Nombre del hotel")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }
    

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
        [Range(1, 5, ErrorMessage = "Las estrellas deben estar entre 1 y 5")]
        public int Stars { get; set; }

        [Display(Name = "Descripción del hotel")]
        [MaxLength(50)]
        [Required(ErrorMessage = "La descripción es requerida")]

        public Guid CityId { get; set; }


        [Display(Name = "Descripción del hotel")]
        [MaxLength(50)]
        [Required(ErrorMessage = "La descripción es requerida")]
        public string? Description { get; set; }
        public ICollection<Room>? Rooms { get; set; }

        public City? City { get; set; }


    }
}
