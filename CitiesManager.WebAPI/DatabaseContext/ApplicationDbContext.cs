using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.DatabaseContext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        { 

        }

        public ApplicationDbContext() { }


        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City() 
            {
                CityId = Guid.Parse("5AC5FB53-F5D1-4FC4-AABF-4E1B4E2A4AC8"),
                CityName = "Bhopal"
            });
            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = Guid.Parse("19FBA6C3-829E-4968-A7E3-87DB6431E31C"),
                CityName = "Ahmedabad"
            });
        }

    }
}
