using VehiculosYa.Securities.Domain.Models;

namespace VehiculosYa.Vehicles.Domain.Repositories;
public interface ISecurityRepository
{
    public Task<List<Security>> Get();
    public Task<Security> GetById(Guid id);
    public Task<Security> Create(Security security);
    public Task<Security> Update(Security security);
    public Task Delete(Guid id);
}