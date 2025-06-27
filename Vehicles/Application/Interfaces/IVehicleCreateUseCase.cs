using VehiculosYa.Vehicles.Domain.Models;

namespace VehiculosYa.Vehicles.Application.Interfaces;
public interface IVehicleCreateUseCase
{
    public Vehicle Execute(Vehicle vehicle); 
}