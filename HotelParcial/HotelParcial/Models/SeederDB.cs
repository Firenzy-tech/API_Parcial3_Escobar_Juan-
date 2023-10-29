using HotelParcial.Models.Entities;

namespace HotelParcial.Models
{
    public class SeederDB
    {
        private readonly DataBaseContext _context;
        public SeederDB(DataBaseContext context)
        {
            _context = context;

        }


        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            await PopulateCitiesAsync();

            await _context.SaveChangesAsync(); 

        }

        private Task PopulateCitiesAsync()
        {
            if (!_context.Countries.Any())
            {
                try
                {
                    _context.Countries.Add(new Country
                    {
                        Name = "Colombia",
                        CreatedDate = DateTime.Now,
                        States = new List<State>()
                {
                    new State
                        {
                            
                            Name = "Antioquia",
                                 Cities = new List<City>()
                                 {
                                   new City
                                   {
                                       CreatedDate = DateTime.Now,
                                       Name = "Medellin"
                                   },
                                   new City
                                   {    CreatedDate = DateTime.Now,
                                        Name = "Envigado"
                                   },
                                   new City
                                   {
                                       CreatedDate = DateTime.Now,
                                       Name = "Bello"
                                   },
                                   new City
                                   {
                                       CreatedDate = DateTime.Now,
                                       Name = "Itagui"
                                   }

                                 }
                        },

                                new State
                                {
                                    
                                    Name = "Cundinamarca",
                                    CreatedDate = DateTime.Now,
                                    Cities = new List<City>()
                                    {
                                        new City
                                        {
                                            CreatedDate = DateTime.Now,
                                            Name = "Bogota"
                                        },
                                        new City
                                        {
                                            CreatedDate = DateTime.Now,
                                            Name = "Chia"
                                        },
                                        new City
                                        {
                                            CreatedDate = DateTime.Now,
                                            Name = "Soacha"
                                        },
                                        new City
                                        {   CreatedDate = DateTime.Now,
                                            Name = "Zipaquira"
                                        }

                                    }
                                },

                       }


                    });

                }
                catch (Exception ex)
                {
                    return Task.FromException(ex);
                    
                }
            }

            return Task.CompletedTask;
        }
    }
}
