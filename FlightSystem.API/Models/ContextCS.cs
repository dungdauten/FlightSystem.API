using FlightSystem.API.Models.DTO;
using FlightSystem.API.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FlightSystem.API.Models
{
    public class ContextCS : DbContext
    {

        public ContextCS(DbContextOptions options) : base(options) { }

        
        public DbSet<AdminLogic> AdminLogics { get; set; }
        public DbSet<UserAccount> UserLogins { get; set; }
        public DbSet<PlaneInfoDTO> PlaneInfo { get; set; }
        public DbSet<FlightBookingDTO> FlightBookings { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
            
        }
        public void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                    new IdentityRole { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                    new IdentityRole { Name = "Nhân viên Go", ConcurrencyStamp = "1", NormalizedName = "Nhân viên Go" },
                    new IdentityRole { Name = "Phi công", ConcurrencyStamp = "1", NormalizedName = "Phi công" },
                    new IdentityRole { Name = "Tiếp viên", ConcurrencyStamp = "1", NormalizedName = "Tiếp viên" }
                );
            builder.Entity<PlaneInfoDTO>().HasData
                (
                    new PlaneInfoDTO { PlaneID = 1, APlaneName = "Air Lines", APlaneCapity = 1000, Price = 10000 },
                    new PlaneInfoDTO { PlaneID = 2, APlaneName = "Vietjet", APlaneCapity = 1500, Price = 500 }
                );
        }
    }
}
