using VehiculosYa.Maintenances.Domain.Models;

namespace VehiculosYa.Maintenances.Application.Interfaces;

public interface IMaintenanceUpdateUseCase
{
    public Maintenance Execute(Maintenance maintenance, Guid id); 
}