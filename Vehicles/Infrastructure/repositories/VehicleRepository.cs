using Microsoft.EntityFrameworkCore;
using VehiculosYa.Common;
using VehiculosYa.Vehicles.Domain.Models;
using VehiculosYa.Vehicles.Domain.Repositories;
using VehiculosYa.Vehicles.infrastructure.Entities;
using VehiculosYa.Vehicles.infrastructure.Mappers;

namespace VehiculosYa.Vehicles.Repository;
public class VehicleRepository: IVehicleRepository
{
    private readonly AppDbContext _context;

    public VehicleRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Vehicle>> Get()
    {
        List<VehicleEntity> vehiclesEntity = await _context.VehicleEntity.ToListAsync();
        List<Vehicle> vehicles = vehiclesEntity.Select(VehicleMapper.ToModel).ToList();
        return vehicles;
    }

    public async Task<Vehicle> GetById(Guid id)
    {
        VehicleEntity? vehicle = await _context.VehicleEntity.FindAsync(id);
        if (vehicle == null)
        {
            throw new Exception(Constant.VehicleNotFound);
        }
        return VehicleMapper.ToModel(vehicle);
    }

    public async Task<Vehicle> GetByPlate(string plate)
    {
        VehicleEntity? vehicle = await _context.VehicleEntity.SingleOrDefaultAsync(v => v.Plate == plate);
        if (vehicle == null)
        {
            throw new Exception(Constant.VehicleNotFound);
        }
        return VehicleMapper.ToModel(vehicle);
    }

    public async Task<Vehicle> Create(Vehicle model)
    {
        VehicleEntity entity = VehicleMapper.ToEntity(model);
        await _context.VehicleEntity.AddAsync(entity);
        await _context.SaveChangesAsync();
        return VehicleMapper.ToModel(entity);
    }

    public async Task<Vehicle> Update(Vehicle model)
    {
        VehicleEntity entity = VehicleMapper.ToEntity(model);
        _context.VehicleEntity.Update(entity);
        await _context.SaveChangesAsync();
        return VehicleMapper.ToModel(entity);
    }

    public async Task Delete(Guid id)
    {
        var vehicleEntity = await _context.VehicleEntity.FindAsync(id);
        if (vehicleEntity != null)
        {
            _context.VehicleEntity.Remove(vehicleEntity);
            await _context.SaveChangesAsync();
        }
    }
}