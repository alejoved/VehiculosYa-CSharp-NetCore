using VehiculosYa.Penalties.Domain.Models;

namespace VehiculosYa.Penalties.Application.Interfaces;

public interface IPenaltyUpdateUseCase
{
    public Penalty Execute(Penalty penalty, Guid id);
}