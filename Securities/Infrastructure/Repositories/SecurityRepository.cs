using Microsoft.EntityFrameworkCore;
using VehiculosYa.Common;
using VehiculosYa.Securities.Domain.Models;
using VehiculosYa.Securities.infrastructure.Entities;
using VehiculosYa.Securities.infrastructure.Mappers;
using VehiculosYa.Vehicles.Domain.Repositories;

namespace VehiculosYa.Securities.Repository;
public class SecurityRepository: ISecurityRepository
{
    private readonly AppDbContext _context;

    public SecurityRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Security>> Get()
    {
        List<SecurityEntity> securitiesEntity = await _context.SecurityEntity.ToListAsync();
        List<Security> securities = securitiesEntity.Select(SecurityMapper.ToModel).ToList();
        return securities;
    }

    public async Task<Security> GetById(Guid id)
    {
        SecurityEntity? security = await _context.SecurityEntity.FindAsync(id);
        if (security == null)
        {
            throw new Exception(Constant.SecurityNotFound);
        }
        return SecurityMapper.ToModel(security);
    }

    public async Task<Security> Create(Security model)
    {
        SecurityEntity entity = SecurityMapper.ToEntity(model);
        await _context.SecurityEntity.AddAsync(entity);
        await _context.SaveChangesAsync();
        return SecurityMapper.ToModel(entity);
    }

    public async Task<Security> Update(Security model)
    {
        SecurityEntity entity = SecurityMapper.ToEntity(model);
        _context.SecurityEntity.Update(entity);
        await _context.SaveChangesAsync();
        return SecurityMapper.ToModel(entity);
    }

    public async Task Delete(Guid id)
    {
        var securityEntity = await _context.SecurityEntity.FindAsync(id);
        if (securityEntity != null)
        {
            _context.SecurityEntity.Remove(securityEntity);
            await _context.SaveChangesAsync();
        }
    }
}