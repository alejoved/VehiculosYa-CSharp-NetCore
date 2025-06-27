using VehiculosYa.Vehicles.Domain.Models;

namespace VehiculosYa.Vehicle.Application.Interfaces;
public interface IVehicleUpdateUseCase
{
    public Vehicle Execute(Vehicle vehicle, Guid id); 
}