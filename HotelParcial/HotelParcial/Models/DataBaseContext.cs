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
            modelBuilder.Entity<Hotel>().HasIndex(h => h.Name).IsUnique();
            modelBuilder.Entity<Room>().HasIndex("Number", "HotelId").IsUnique();
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); 
            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique(); 

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Country> Countries { get; set; } 
        public DbSet<State> States { get; set; }

    }
}
