using VehiculosYa.Securities.Domain.Models;

namespace VehiculosYa.Securities.Application.Interfaces;
public interface ISecurityCreateUseCase
{
    public Security Execute(Security security); 
}