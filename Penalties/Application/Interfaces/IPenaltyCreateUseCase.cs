using VehiculosYa.Penalties.Domain.Models;

namespace VehiculosYa.Penalties.Application.Interfaces;
public interface IPenaltyCreateUseCase
{
    public Penalty Execute(Penalty penalty); 
}