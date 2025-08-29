using VehiculosYa.Securities.Domain.Models;

namespace VehiculosYa.Securities.Application.Interfaces;

public interface ISecurityGetUseCase
{
    public List<Security> Execute();
    public Security ExecuteById(Guid id);
}