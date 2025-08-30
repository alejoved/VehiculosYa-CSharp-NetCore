using VehiculosYa.Penalties.Domain.Models;
using VehiculosYa.Penalties.Interface.Rest.Dtos;

namespace VehiculosYa.Securities.Interface.Rest.Mappers;

public class PenaltyRestMapper
{
    public static Penalty ToModel(PenaltyDto dto)
    {
        return new Penalty
        {
            Description = dto.Description,
            Type = dto.Type,
            Amount = dto.Amount,
            Status = dto.Status
        };
    }

    public static PenaltyResponseDto ToDto(Penalty model)
    {
        return new PenaltyResponseDto
        {
            Type = model.Type,
            Amount = model.Amount,
            Status = model.Status
        };
    }
}