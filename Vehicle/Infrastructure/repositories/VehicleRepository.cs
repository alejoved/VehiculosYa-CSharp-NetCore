using Microsoft.EntityFrameworkCore;
using VehiculosYa.Common;
using VehiculosYa.Vehicle.Entity;

namespace VehiculosYa.Vehicle.Repository;
public class VehicleRepository : IVehicleRepository
{
    private readonly AppDbContext _context;

    public VehicleRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<VehicleEntity>> GetAllAsync()
    {
        return await _context.VehicleEntity.ToListAsync();
    }

    public async Task<VehicleEntity?> GetByIdAsync(Guid id)
    {
        return await _context.VehicleEntity.FindAsync(id);
    }

    public async Task<VehicleEntity> AddAsync(VehicleEntity entity)
    {
        await _context.VehicleEntity.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(VehicleEntity entity)
    {
        _context.VehicleEntity.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var vehicleEntity = await GetByIdAsync(id);
        if (vehicleEntity != null)
        {
            _context.VehicleEntity.Remove(vehicleEntity);
            await _context.SaveChangesAsync();
        }
    }
}