using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataAccess.Concrete.EntityFramework;

public class CarRentalManagementContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // docker & azure data studio with ms sql server
        optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=CarRentalManagement;
        User Id=SA;Password=reallyStrongPwd123;Trusted_Connection=false;TrustServerCertificate=True;
        MultiSubnetFailover=True");
    }
    
    public DbSet<Car> Cars { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Brand> Brands { get; set; }

}