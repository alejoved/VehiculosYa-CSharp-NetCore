using Microsoft.AspNetCore.Mvc;
using VehiculosYa.Securities.Application.Interfaces;
using VehiculosYa.Securities.Domain.Models;
using VehiculosYa.Securities.Interface.Rest.Dtos;
using VehiculosYa.Securities.Interface.Rest.Mappers;
namespace VehiculosYa.Securities.Interface.Rest.Controller;

[ApiController]
[Route("[controller]")]
public class SecurityController : ControllerBase
{
    private readonly ISecurityGetUseCase securityGetUseCase;
    private readonly ISecurityCreateUseCase securityCreateUseCase;
    private readonly ISecurityUpdateUseCase securityUpdateUseCase;
    private readonly ISecurityDeleteUseCase securityDeleteUseCase;
    public SecurityController(ISecurityGetUseCase securityGetUseCase, ISecurityCreateUseCase securityCreateUseCase, ISecurityUpdateUseCase securityUpdateUseCase, ISecurityDeleteUseCase securityDeleteUseCase)
    {
        this.securityGetUseCase = securityGetUseCase;
        this.securityCreateUseCase = securityCreateUseCase;
        this.securityUpdateUseCase = securityUpdateUseCase;
        this.securityDeleteUseCase = securityDeleteUseCase;
    }

    [HttpGet]
    public List<SecurityResponseDto> GetAll()
    {
        List<Security> securityModels = securityGetUseCase.Execute();
        return securityModels.Select(SecurityRestMapper.ToDto).ToList();
    }

    [HttpGet("{id}")]
    public SecurityResponseDto GetById(Guid id)
    {
        Security securityModel = securityGetUseCase.ExecuteById(id);
        return SecurityRestMapper.ToDto(securityModel);
    }

    [HttpPost]
    public SecurityResponseDto Create(SecurityDto securityDto)
    {
        Security security = SecurityRestMapper.ToModel(securityDto);
        Security response = securityCreateUseCase.Execute(security);
        return SecurityRestMapper.ToDto(response);

    }

    [HttpPut("{id}")]
    public SecurityResponseDto Update(SecurityDto securityDto, Guid id)
    {
        Security security = SecurityRestMapper.ToModel(securityDto);
        Security response = securityUpdateUseCase.Execute(security, id);
        return SecurityRestMapper.ToDto(response);
    }

    [HttpDelete("{id}")]
    public void Delete(Guid id)
    {
        securityDeleteUseCase.Execute(id);
    }
}
