using VehiculosYa.Securities.Domain.Models;

namespace VehiculosYa.Securities.Application.Interfaces;
public interface ISecurityUpdateUseCase
{
    public Security Execute(Security security, Guid id);
}