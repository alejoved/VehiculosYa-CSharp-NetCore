using Microsoft.AspNetCore.Mvc;
using VehiculosYa.Vehicles.Application.Interfaces;
using VehiculosYa.Vehicles.Domain.Models;
using VehiculosYa.Vehicles.Interface.Rest.Dtos;
using VehiculosYa.Vehicles.Interface.Rest.Mappers;

namespace VehiculosYa.Vehicles.Interface.Rest.Controller;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IVehicleGetUseCase vehicleGetUseCase;
    private readonly IVehicleCreateUseCase vehicleCreateUseCase;
    private readonly IVehicleUpdateUseCase vehicleUpdateUseCase;
    private readonly IVehicleDeleteUseCase vehicleDeleteUseCase;
    public VehicleController(IVehicleGetUseCase vehicleGetUseCase, IVehicleCreateUseCase vehicleCreateUseCase, IVehicleUpdateUseCase vehicleUpdateUseCase, IVehicleDeleteUseCase vehicleDeleteUseCase)
    {
        this.vehicleGetUseCase = vehicleGetUseCase;
        this.vehicleCreateUseCase = vehicleCreateUseCase;
        this.vehicleUpdateUseCase = vehicleUpdateUseCase;
        this.vehicleDeleteUseCase = vehicleDeleteUseCase;
    }

    [HttpGet]
    public List<VehicleResponseDto> GetAll()
    {
        List<Vehicle> vehicleModels = vehicleGetUseCase.Execute();
        return vehicleModels.Select(VehicleRestMapper.ToDto).ToList();
    }

    [HttpGet("{id}")]
    public VehicleResponseDto GetById(Guid id)
    {
        Vehicle vehicleModel = vehicleGetUseCase.ExecuteById(id);
        return VehicleRestMapper.ToDto(vehicleModel);
    }

    [HttpPost]
    public VehicleResponseDto Create(VehicleDto vehicleDto)
    {
        Vehicle vehicle = VehicleRestMapper.ToModel(vehicleDto);
        Vehicle response = vehicleCreateUseCase.Execute(vehicle);
        return VehicleRestMapper.ToDto(response);

    }

    [HttpPut("{id}")]
    public VehicleResponseDto Update(VehicleDto vehicleDto, Guid id)
    {
        Vehicle vehicle = VehicleRestMapper.ToModel(vehicleDto);
        Vehicle response = vehicleUpdateUseCase.Execute(vehicle, id);
        return VehicleRestMapper.ToDto(response);
    }

    [HttpDelete("{id}")]
    public void Delete(Guid id)
    {
        vehicleDeleteUseCase.Execute(id);
    }
}
