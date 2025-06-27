
using VehiculosYa.Vehicles.Domain.Models;
using VehiculosYa.Vehicles.Entity;

namespace VehiculosYa.Vehicles.infrastructure.Mappers;

public class VehicleMapper
{
    public static VehicleModel ToModel(VehicleEntity entity)
    {
        return new VehicleModel
        {
            Id = entity.Id,
            Plate = entity.Plate,
            Brand = entity.Brand,
            Model = entity.Model
        };
    }

    public static VehicleEntity ToEntity(VehicleModel model)
    {
        return new VehicleEntity
        {
            Id = model.Id,
            Plate = model.Plate,
            Brand = model.Brand,
            Model = model.Model
        };
    }
}