using System.ComponentModel.DataAnnotations;

namespace HotelParcial.Models.Entities
{
    public class AuditBase
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
