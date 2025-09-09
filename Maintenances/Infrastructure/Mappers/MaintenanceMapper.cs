namespace VehiculosYa.Maintenances.infrastructure.Mappers;
public class MaintenanceMapper
{
    public static Maintenance ToModel(MaintenanceEntity entity)
    {
        return new Maintenance
        {
            Id = entity.Id,
            Description = entity.Description,
            Type = entity.Type,
            Amount = entity.Amount,
            Status = entity.Status
            
        };
    }

    public static PenaltyEntity ToEntity(Penalty model)
    {
        return new PenaltyEntity
        {
            Id = model.Id,
            Description = model.Description,
            Type = model.Type,
            Amount = model.Amount,
            Status = model.Status
        };
    }
}