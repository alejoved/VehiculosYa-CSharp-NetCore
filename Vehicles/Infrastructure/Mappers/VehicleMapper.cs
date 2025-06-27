namespace VehiculosYa.Vehicles.infrastructure.Mappers;
public class VehicleMapper
{
    public static Vehicle ToModel(VehicleEntity entity)
    {
        return new Vehicle
        {
            Id = entity.Id,
            Plate = entity.Plate,
            Brand = entity.Brand,
            Model = entity.Model,
            Kms = entity.Kms
        };
    }

    public static VehicleEntity ToEntity(Vehicle model)
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