using Microsoft.EntityFrameworkCore;
using VehiculosYa.Securities.infrastructure.Entities;
using VehiculosYa.Vehicles.infrastructure.Entities;

namespace VehiculosYa.Common;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<VehicleEntity> VehicleEntity { get; set; }
    public DbSet<SecurityEntity> SecurityEntity { get; set; }
}