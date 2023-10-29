namespace HotelParcial.Models.Entities
{
    public class City: AuditBase
    {
        public State? State { get; set; } //Este representa un OBJETO DE COUNTRY
        public string Name { get; set; }    

    }
}
