using DisasterFoundationWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DisasterFoundationWebApp.Data
{
  

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Donation> Donations { get; set; }
        public DbSet<MonetaryDonation> MonetaryDonations { get; set; }
        public DbSet<GoodsDonation> GoodsDonations { get; set; }
        public DbSet<Allocation> Allocations { get; set; }
        public DbSet<Disaster> Disasters { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

      
    }

}
