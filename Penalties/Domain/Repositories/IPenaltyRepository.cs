using VehiculosYa.Penalties.Domain.Models;

namespace VehiculosYa.Penalties.Domain.Repositories;
public interface IPenaltyRepository
{
    public Task<List<Penalty>> Get();
    public Task<Penalty> GetById(Guid id);
    public Task<Penalty> Create(Penalty penalty);
    public Task<Penalty> Update(Penalty penalty);
    public Task Delete(Guid id);
}