using Microsoft.Data.Entity;
using VehWebApp.Models.Vehicles;

namespace VehWebApp.DataLayer
{
    public class VehDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        //no need for the second set, we save 
        //this type in one table among with the Vehicle type
        //public DbSet<UsedVehicle> UsedVehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //For demonstration purposes I save 
            //inherited object using TPH pattern
            modelBuilder.Entity<Vehicle>()
                .HasDiscriminator<bool>("used_car") //add new column named used_car to table
                .HasValue<Vehicle>(false)
                .HasValue<UsedVehicle>(true);

        }

        // No need for this now, configuration starts globally inside from Startup.cs ConfigureServices
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     var path = PlatformServices.Default.Application.ApplicationBasePath;
        //     optionsBuilder.UseSqlite("Filename=" + Path.Combine(path, "vehicles.db"));
        // }
    }
}