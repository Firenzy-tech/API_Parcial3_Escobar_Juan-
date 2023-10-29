using HotelParcial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelParcial.Models
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>().HasIndex("Name", "CityId").IsUnique();
            modelBuilder.Entity<Room>().HasIndex("Number", "HotelId").IsUnique();
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); 
            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique(); 
            modelBuilder.Entity<City>().HasIndex("Name", "StateId").IsUnique();
            modelBuilder.Entity<Room>().Property(r => r.Price).HasColumnType("decimal(18, 2)");


        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Country> Countries { get; set; } 
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
