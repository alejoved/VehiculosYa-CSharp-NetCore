using VehiculosYa.Vehicles.Domain.Models;

namespace VehiculosYa.Vehicle.Application.Interfaces;
public interface IVehicleCreateUseCase
{
    public Vehicle Execute(Vehicle vehicle); 
}