using Microsoft.AspNetCore.Mvc;
using VehiculosYa.Vehicle.Dto;
using VehiculosYa.Vehicle.Service;

namespace VehiculosYa.Vehicle.Controller;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IVehicleService service;
    public VehicleController(IVehicleService service)
    {
        this.service = service;
    }

    [HttpGet]
    public List<VehicleResponseDTO> GetAll()
    {
        return service.GetAll();
    }

    [HttpGet("{id}")]
    public List<VehicleResponseDTO> GetById(Guid id)
    {
        return service.GetById(id);
    }

    [HttpPost]
    public List<VehicleResponseDTO> GetById(VehicleDTO vehicleDTO)
    {
        return service.Create(vehicleDTO);
    }

    [HttpPut("{id}")]
    public List<VehicleResponseDTO> update(Guid id, VehicleDTO vehicleDTO)
    {
        return service.update(id, vehicleDTO);
    }

    [HttpDelete("{id}")]
    public List<VehicleResponseDTO> update(Guid id)
    {
        return service.delete(id);
    }
}
