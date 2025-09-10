using VehiculosYa.Securities.Domain.Models;
using VehiculosYa.Securities.Interface.Rest.Dtos;

namespace VehiculosYa.Securities.Interface.Rest.Mappers;

public class SecurityRestMapper
{
    public static Security CreateDtoToModel(SecurityCreateDto dto)
    {
        return new Security
        {
            Date = dto.Date,
            Description = dto.Description,
            Type = dto.Type,
            Cost = dto.Cost,
            Status = dto.Status
        };
    }

    public static Security UpdateDtoToModel(SecurityUpdateDto dto, Guid id)
    {
        return new Security
        {
            Id = id,
            Date = dto.Date,
            Description = dto.Description,
            Type = dto.Type,
            Cost = dto.Cost,
            Status = dto.Status
        };
    }

    public static SecurityResponseDto ToDto(Security model)
    {
        return new SecurityResponseDto
        {
            Id = model.Id,
            Date = model.Date,
            Description = model.Description,
            Type = model.Type,
        };
    }
}