using VehiculosYa.Penalties.Domain.Models;
using VehiculosYa.Securities.infrastructure.Entities;

namespace VehiculosYa.Penalties.infrastructure.Mappers;
public class PenaltyMapper
{
    public static Penalty ToModel(PenaltyEntity entity)
    {
        return new Penalty
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