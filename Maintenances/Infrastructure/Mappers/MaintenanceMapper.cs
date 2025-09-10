using VehiculosYa.Maintenances.Domain.Models;
using VehiculosYa.Maintenances.infrastructure.Entities;

namespace VehiculosYa.Maintenances.infrastructure.Mappers;
public class MaintenanceMapper
{
    public static Maintenance ToModel(MaintenanceEntity entity)
    {
        return new Maintenance
        {
            Id = entity.Id,
            Date = entity.Date,
            Description = entity.Description,
            Type = entity.Type,
            Cost = entity.Cost,
            
        };
    }

    public static MaintenanceEntity ToEntity(Maintenance model)
    {
        return new MaintenanceEntity
        {
            Id = model.Id,
            Date = model.Date,
            Description = model.Description,
            Type = model.Type,
            Cost = model.Cost,
        };
    }
}