using VehiculosYa.Maintenances.Domain.Models;

namespace VehiculosYa.Maintenances.Domain.Repositories;
public interface IMaintenanceRepository
{
    public Task<List<Maintenance>> Get();
    public Task<Maintenance> GetById(Guid id);
    public Task<Maintenance> Create(Maintenance maintenance);
    public Task<Maintenance> Update(Maintenance maintenance);
    public Task Delete(Guid id);
}