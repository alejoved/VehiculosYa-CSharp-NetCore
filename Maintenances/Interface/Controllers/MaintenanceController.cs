using Microsoft.AspNetCore.Mvc;
using VehiculosYa.Maintenances.Application.Interfaces;
using VehiculosYa.Maintenances.Domain.Models;
using VehiculosYa.Maintenances.infrastructure.Mappers;
using VehiculosYa.Maintenances.Interface.Rest.Dtos;

namespace VehiculosYa.Vehicles.Interface.Rest.Controller;

[ApiController]
[Route("[controller]")]
public class MaintenanceController : ControllerBase
{
    private readonly IMaintenanceGetUseCase maintenanceGetUseCase;
    private readonly IMaintenanceCreateUseCase maintenanceCreateUseCase;
    private readonly IMaintenanceUpdateUseCase maintenanceUpdateUseCase;
    private readonly IMaintenanceDeleteUseCase maintenanceDeleteUseCase;
    public MaintenanceController(IMaintenanceGetUseCase maintenanceGetUseCase, IMaintenanceCreateUseCase maintenanceCreateUseCase, IMaintenanceUpdateUseCase maintenanceUpdateUseCase, IMaintenanceDeleteUseCase maintenanceDeleteUseCase)
    {
        this.maintenanceGetUseCase = maintenanceGetUseCase;
        this.maintenanceCreateUseCase = maintenanceCreateUseCase;
        this.maintenanceUpdateUseCase = maintenanceUpdateUseCase;
        this.maintenanceDeleteUseCase = maintenanceDeleteUseCase;
    }

    [HttpGet]
    public List<MaintenanceResponseDto> GetAll()
    {
        List<Maintenance> maintenances = maintenanceGetUseCase.Execute();
        return maintenances.Select(MaintenanceRestMapper.ToDto).ToList();
    }

    [HttpGet("{id}")]
    public MaintenanceResponseDto GetById(Guid id)
    {
        Maintenance maintenance = maintenanceGetUseCase.ExecuteById(id);
        return MaintenanceRestMapper.ToDto(maintenance);
    }

    [HttpPost]
    public MaintenanceResponseDto Create(MaintenanceCreateDto maintenanceCreateDto)
    {
        Maintenance maintenance = MaintenanceRestMapper.CreateDtoToModel(maintenanceCreateDto);
        Maintenance response = maintenanceCreateUseCase.Execute(maintenance);
        return MaintenanceRestMapper.ToDto(response);

    }

    [HttpPut("{id}")]
    public MaintenanceResponseDto Update(MaintenanceUpdateDto maintenanceUpdateDto, Guid id)
    {
        Maintenance maintenance = MaintenanceRestMapper.UpdateDtoToModel(maintenanceUpdateDto);
        Maintenance response = maintenanceUpdateUseCase.Execute(maintenance, id);
        return MaintenanceRestMapper.ToDto(response);
    }

    [HttpDelete("{id}")]
    public void Delete(Guid id)
    {
        maintenanceDeleteUseCase.Execute(id);
    }
}