using VehiculosYa.Maintenances.Domain.Models;
using VehiculosYa.Maintenances.Interface.Rest.Dtos;

namespace VehiculosYa.Maintenances.infrastructure.Mappers;
public class MaintenanceRestMapper
{
    public static Maintenance CreateDtoToModel(MaintenanceCreateDto dto)
    {
        return new Maintenance
        {
            Date = dto.Date,
            Description = dto.Description,
            Type = dto.Type,
            Cost = dto.Cost,
            
        };
    }

    public static Maintenance UpdateDtoToModel(MaintenanceUpdateDto dto)
    {
        return new Maintenance
        {
            Date = dto.Date,
            Description = dto.Description,
            Type = dto.Type,
            Cost = dto.Cost,
            
        };
    }

    public static MaintenanceResponseDto ToDto(Maintenance model)
    {
        return new MaintenanceResponseDto
        {
            Id = model.Id,
            Date = model.Date,
            Description = model.Description,
            Type = model.Type,
            Cost = model.Cost,
        };
    }
}