using VehiculosYa.Vehicles.Application.Interfaces;
using VehiculosYa.Vehicles.Domain.Models;

namespace VehiculosYa.Vehicle.Application.UseCases;

public class VehicleGetUseCase : IVehicleGetUseCase
{
    public List<Vehicle> Execute()
    {
        throw new NotImplementedException();
    }

    public Vehicle ExecuteById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Vehicle executeByPlate(string plate)
    {
        throw new NotImplementedException();
    }
}