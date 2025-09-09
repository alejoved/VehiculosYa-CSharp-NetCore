using VehiculosYa.Maintenances.Domain.Models;

namespace VehiculosYa.Maintenances.Application.Interfaces;

public interface IMaintenanceCreateUseCase
{
    public Maintenance Execute(Maintenance maintenance); 
}