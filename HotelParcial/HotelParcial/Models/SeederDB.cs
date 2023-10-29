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

            //await PopulateHotelAsync();

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
                                       Name = "Medellin",
                                       Hotels= new List<Hotel>()
                                       {
                                             new Hotel
                                             {
                                                  Name = "Hotel Plaza",
                                                  Address = "Calle 10 # 10-10",
                                                  Phone = "1234567",
                                                  Description = "Hotel Ejecutivo",
                                                  Stars = 5,
                                                  Rooms = new List<Room>
                                                  {
                                                    new Room
                                                    {
                                                         Number = "101",
                                                         Price = 100000,
                                                         Description = "Habitación sencilla",
                                                         Availability = false,
                                                         CreatedDate = DateTime.Now,
                                                    },
                                                    new Room
                                                    {
                                                         Number = "102",
                                                         Price = 200000,
                                                         Description = "Habitación doble",
                                                         Availability = true,
                                                         CreatedDate = DateTime.Now
                                                    },
                                                  }
                                             }
                                       }
                                   },
                                   new City
                                   {    CreatedDate = DateTime.Now,
                                        Name = "Envigado",
                                        Hotels= new List<Hotel>()
                                        {
                                             new Hotel
                                             {
                                                  Name = "Hotel Dorado",
                                                  Address = "Calle 20 # 20-20",
                                                  Phone = "1234567",
                                                  Description = "Hotel Familiar",
                                                  Stars = 4,
                                                  Rooms = new List<Room>
                                                  {
                                                    new Room
                                                    {
                                                         Number = "201",
                                                         Price = 100000,
                                                         Description = "Habitación sencilla",
                                                         Availability = true,
                                                         CreatedDate = DateTime.Now
                                                    },
                                                    new Room
                                                    {
                                                         Number = "202",
                                                         Price = 200000,
                                                         Description = "Habitación doble",
                                                         Availability = false,
                                                         CreatedDate = DateTime.Now
                                                    },
                                                  }
                                             }
                                        }
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
                                            Name = "Bogota",
                                            Hotels= new List<Hotel>()
                                            {
                                                new Hotel
                                                {
                                                    Name = "Hotel Plaza",
                                                    Address = "Calle 10 # 10-10",
                                                    Phone = "1234567",
                                                    Description = "Hotel Ejecutivo",
                                                    Stars = 5,
                                                    Rooms = new List<Room>
                                                    {
                                                        new Room
                                                        {
                                                            Number = "101",
                                                            Price = 100000,
                                                            Description = "Habitación sencilla",
                                                            Availability = false,
                                                            CreatedDate = DateTime.Now,
                                                        },
                                                        new Room
                                                        {
                                                            Number = "102",
                                                            Price = 200000,
                                                            Description = "Habitación doble",
                                                            Availability = true,
                                                            CreatedDate = DateTime.Now
                                                        },
                                                    }
                                                }
                                            }
                                        },
                                        new City
                                        {
                                            CreatedDate = DateTime.Now,
                                            Name = "Chia",
                                            Hotels= new List<Hotel>()
                                            {
                                                new Hotel
                                                {
                                                    Name = "Hotel Dorado",
                                                    Address = "Calle 20 # 20-20",
                                                    Phone = "1234567",
                                                    Description = "Hotel Familiar",
                                                    Stars = 4,
                                                    Rooms = new List<Room>
                                                    {
                                                        new Room
                                                        {
                                                            Number = "201",
                                                            Price = 100000,
                                                            Description = "Habitación sencilla",
                                                            Availability = true,
                                                            CreatedDate = DateTime.Now
                                                        },
                                                        new Room
                                                        {
                                                            Number = "202",
                                                            Price = 200000,
                                                            Description = "Habitación doble",
                                                            Availability = false,
                                                            CreatedDate = DateTime.Now
                                                        },
                                                    }
                                                }
                                            }
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


        //private async Task PopulateHotelAsync()
        //{
        //    if (!_context.Hotels.Any())
        //    {
        //        _context.Hotels.AddRange(new List<Hotel>
        //{
        //    new Hotel
        //    {
        //        Name = "Hotel Plaza",
        //        Address = "Calle 10 # 10-10",
        //        Phone = "1234567",
        //         Description = "Hotel Ejecutivo",
        //         Stars = 5,
        //        Rooms = new List<Room>
        //        {
        //            new Room
        //            {
        //                Number = "101",
        //                Price = 100000,
        //                Description = "Habitación sencilla",
        //                Availability = false,
        //                CreatedDate = DateTime.Now,


        //            },
        //            new Room
        //            {
        //                Number = "102",
        //                Price = 200000,
        //                Description = "Habitación doble",
        //                Availability = true,
        //                CreatedDate = DateTime.Now
        //            },
        //            new Room
        //            {
        //                Number = "103",
        //                Price = 300000,
        //                Description = "Habitación triple",
        //                HotelId = 1,
        //                Availability = true,
        //                CreatedDate = DateTime.Now
        //            }
        //        }
        //    },
        //    new Hotel
        //    {
        //        Name = "Hotel Dorado",
        //        Address = "Calle 20 # 20-20",
        //        Phone = "1234567",
        //        Description = "Hotel Familiar",
        //        Stars = 4,
        //        Rooms = new List<Room>
        //        {
        //            new Room
        //            {
        //                Number = "201",
        //                Price = 100000,
        //                Description = "Habitación sencilla",
        //                Availability = true,
        //                CreatedDate = DateTime.Now
        //            },
        //            new Room
        //            {
        //                Number = "202",
        //                Price = 200000,
        //                Description = "Habitación doble",
        //                Availability = false,
        //                CreatedDate = DateTime.Now
        //            },
        //            new Room
        //            {
        //                Number = "203",
        //                Price = 300000,
        //                Description = "Habitación triple",
        //                HotelId = 2,
        //                Availability = true,
        //                CreatedDate = DateTime.Now
        //            }
        //        }
        //    }
        //});

        //    }
        //}

    }
}
