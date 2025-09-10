using VehiculosYa.Vehicles.Domain.Models;
using VehiculosYa.Vehicles.Interface.Rest.Dtos;

namespace VehiculosYa.Vehicles.Interface.Rest.Mappers;

public class VehicleRestMapper
{
    public static Vehicle CreateDtoToModel(VehicleCreateDto dto)
    {
        return new Vehicle
        {
            Plate = dto.Plate,
            Brand = dto.Brand,
            Model = dto.Model,
            Kms = dto.Kms
        };
    }

    public static Vehicle UpdateDtoToModel(VehicleUpdateDto dto, Guid id)
    {
        return new Vehicle
        {
            Id = id,
            Plate = dto.Plate,
            Brand = dto.Brand,
            Model = dto.Model,
            Kms = dto.Kms
        };
    }

    public static VehicleResponseDto ToDto(Vehicle model)
    {
        return new VehicleResponseDto
        {
            Id = model.Id,
            Plate = model.Plate,
            Brand = model.Brand,
            Model = model.Model,
            Kms = model.Kms
        };
    }
}