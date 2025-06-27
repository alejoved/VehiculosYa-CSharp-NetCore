using VehiculosYa.Vehicles.Domain.Models;

namespace VehiculosYa.Vehicles.Application.Interfaces;
public interface IVehicleUpdateUseCase
{
    public Vehicle Execute(Vehicle vehicle, Guid id); 
}