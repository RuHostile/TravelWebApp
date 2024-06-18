namespace TravelWebApp.Models
{
    public class Business
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<int>? OwnerIds { get; set; }
        public List<int>? EventIds { get; set; }
        public List<int>? HotelIds { get; set; }
        public List<int>? RestaurauntIds { get; set; }
    }
}
