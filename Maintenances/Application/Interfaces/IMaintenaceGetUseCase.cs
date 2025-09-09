using VehiculosYa.Maintenances.Domain.Models;

namespace VehiculosYa.Maintenances.Application.Interfaces;

public interface IMaintenanceGetUseCase
{
    public List<Maintenance> Execute(); 
    public Maintenance ExecuteById(Guid id); 
}