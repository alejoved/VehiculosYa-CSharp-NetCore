using System.Threading.Tasks;
using VehiculosYa.Vehicle.Dto;
using VehiculosYa.Vehicle.Entity;
using VehiculosYa.Vehicle.Repository;

namespace VehiculosYa.Vehicle.Service;

public class VehicleService : IVehicleService
{
    private readonly IVehicleRepository repository;

    public VehicleService(IVehicleRepository repository)
    {
        this.repository = repository;
    }

    public async Task<List<VehicleResponseDTO>> GetAll()
    {
        List<VehicleEntity> vehicles = await repository.GetAllAsync();
        
    }

    public VehicleResponseDTO GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public VehicleResponseDTO Create(VehicleDTO obj)
    {
        throw new NotImplementedException();
    }

    public VehicleResponseDTO Update(VehicleDTO obj, Guid id)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}