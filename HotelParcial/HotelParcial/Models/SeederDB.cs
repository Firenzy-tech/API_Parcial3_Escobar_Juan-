namespace HotelParcial.Models
{
    public class SeederDB
    {
        private readonly DataBaseContext _context;



        public SeederDB(DataBaseContext context)
        {
            _context = context;
                
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            //await CheckHotelsAsync();
            //await CheckRoomsAsync();

        }

    }
}
