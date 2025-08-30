using Microsoft.EntityFrameworkCore;
using VehiculosYa.Common;
using VehiculosYa.Penalties.Domain.Models;
using VehiculosYa.Penalties.Domain.Repositories;
using VehiculosYa.Penalties.infrastructure.Mappers;
using VehiculosYa.Securities.infrastructure.Entities;

namespace VehiculosYa.Penalties.Repository;
public class PenaltyRepository: IPenaltyRepository
{
    private readonly AppDbContext _context;

    public PenaltyRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Penalty>> Get()
    {
        List<PenaltyEntity> penaltiesEntity = await _context.PenaltyEntity.ToListAsync();
        List<Penalty> penalties = penaltiesEntity.Select(PenaltyMapper.ToModel).ToList();
        return penalties;
    }

    public async Task<Penalty> GetById(Guid id)
    {
        PenaltyEntity? penalty = await _context.PenaltyEntity.FindAsync(id);
        if (penalty == null)
        {
            throw new Exception(Constant.PenaltyNotFound);
        }
        return PenaltyMapper.ToModel(penalty);
    }

    public async Task<Penalty> Create(Penalty model)
    {
        PenaltyEntity entity = PenaltyMapper.ToEntity(model);
        await _context.PenaltyEntity.AddAsync(entity);
        await _context.SaveChangesAsync();
        return PenaltyMapper.ToModel(entity);
    }

    public async Task<Penalty> Update(Penalty model)
    {
        PenaltyEntity entity = PenaltyMapper.ToEntity(model);
        _context.PenaltyEntity.Update(entity);
        await _context.SaveChangesAsync();
        return PenaltyMapper.ToModel(entity);
    }

    public async Task Delete(Guid id)
    {
        var penaltyEntity = await _context.PenaltyEntity.FindAsync(id);
        if (penaltyEntity != null)
        {
            _context.PenaltyEntity.Remove(penaltyEntity);
            await _context.SaveChangesAsync();
        }
    }
}