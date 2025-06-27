using VehiculosYa.Vehicles.Domain.Models;

namespace VehiculosYa.Vehicles.Domain.Repositories;
public interface IVehicleRepository
{
    public Task<List<Vehicle>> Get();
    public Task<Vehicle> GetById(Guid id);
    public Task<Vehicle> GetByPlate(string plate);
    public Task<Vehicle> Create(Vehicle vehicle);
    public Task<Vehicle> Update(Vehicle vehicle);
    public Task Delete(Guid id);
}