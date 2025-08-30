using VehiculosYa.Penalties.Domain.Models;

namespace VehiculosYa.Penalties.Application.Interfaces;

public interface IPenaltyGetUseCase
{
    public List<Penalty> Execute();
    public Penalty ExecuteById(Guid id);
}