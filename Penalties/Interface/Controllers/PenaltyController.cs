using Microsoft.AspNetCore.Mvc;
using VehiculosYa.Penalties.Application.Interfaces;
using VehiculosYa.Penalties.Domain.Models;
using VehiculosYa.Penalties.Interface.Rest.Dtos;
using VehiculosYa.Penalties.Interface.Rest.Mappers;

namespace VehiculosYa.penalties.Interface.Rest.Controller;

[ApiController]
[Route("[controller]")]
public class PenaltyController : ControllerBase
{
    private readonly IPenaltyGetUseCase penaltyGetUseCase;
    private readonly IPenaltyCreateUseCase penaltyCreateUseCase;
    private readonly IPenaltyUpdateUseCase penaltyUpdateUseCase;
    private readonly IPenaltyDeleteUseCase penaltyDeleteUseCase;
    public PenaltyController(IPenaltyGetUseCase penaltyGetUseCase, IPenaltyCreateUseCase penaltyCreateUseCase, IPenaltyUpdateUseCase penaltyUpdateUseCase, IPenaltyDeleteUseCase penaltyDeleteUseCase)
    {
        this.penaltyGetUseCase = penaltyGetUseCase;
        this.penaltyCreateUseCase = penaltyCreateUseCase;
        this.penaltyUpdateUseCase = penaltyUpdateUseCase;
        this.penaltyDeleteUseCase = penaltyDeleteUseCase;
    }

    [HttpGet]
    public List<PenaltyResponseDto> GetAll()
    {
        List<Penalty> penaltyModels = penaltyGetUseCase.Execute();
        return penaltyModels.Select(PenaltyRestMapper.ToDto).ToList();
    }

    [HttpGet("{id}")]
    public PenaltyResponseDto GetById(Guid id)
    {
        Penalty penaltyModel = penaltyGetUseCase.ExecuteById(id);
        return PenaltyRestMapper.ToDto(penaltyModel);
    }

    [HttpPost]
    public PenaltyResponseDto Create(PenaltyCreateDto penaltyCreateDto)
    {
        Penalty penalty = PenaltyRestMapper.CreateDtoToModel(penaltyCreateDto);
        Penalty response = penaltyCreateUseCase.Execute(penalty);
        return PenaltyRestMapper.ToDto(response);

    }

    [HttpPut("{id}")]
    public PenaltyResponseDto Update(PenaltyUpdateDto penaltyDto, Guid id)
    {
        Penalty penalty = PenaltyRestMapper.UpdateDtoToModel(penaltyDto);
        Penalty response = penaltyUpdateUseCase.Execute(penalty, id);
        return PenaltyRestMapper.ToDto(response);
    }

    [HttpDelete("{id}")]
    public void Delete(Guid id)
    {
        penaltyDeleteUseCase.Execute(id);
    }
}