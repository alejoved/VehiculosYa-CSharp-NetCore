using Microsoft.EntityFrameworkCore;
using VehiculosYa.Vehicle.Entity;

namespace VehiculosYa.Common;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
    }

    public DbSet<VehicleEntity> VehicleEntity { get; set; }
}