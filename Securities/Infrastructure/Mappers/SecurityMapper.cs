using VehiculosYa.Securities.Domain.Models;
using VehiculosYa.Securities.infrastructure.Entities;

namespace VehiculosYa.Securities.infrastructure.Mappers;
public class SecurityMapper
{
    public static Security ToModel(SecurityEntity entity)
    {
        return new Security
        {
            Id = entity.Id,
            Date = entity.Date,
            Description = entity.Description,
            Type = entity.Type,
            Cost = entity.Cost,
            Status = entity.Status
            
        };
    }

    public static SecurityEntity ToEntity(Security model)
    {
        return new SecurityEntity
        {
            Id = model.Id,
            Date = model.Date,
            Description = model.Description,
            Type = model.Type,
            Cost = model.Cost,
            Status = model.Status
        };
    }
}