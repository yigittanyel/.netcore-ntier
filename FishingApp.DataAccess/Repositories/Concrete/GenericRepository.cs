using FishingApp.Core.Primitives;
using FishingApp.DataAccess.Context;
using FishingApp.DataAccess.Repositories.Abstract;
using FishingApp.DataAccess.UnitOfWorks.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.DataAccess.Repositories.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity<int>, new()
    {
        private readonly ApplicationDbContext _aspNetCoreNTierDbContext;
        private readonly IUnitOfWork _unitOfWork;
        public GenericRepository(ApplicationDbContext aspNetCoreNTierDbContext, IUnitOfWork unitOfWork)
        {
            _aspNetCoreNTierDbContext = aspNetCoreNTierDbContext;
            _unitOfWork = unitOfWork;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await _aspNetCoreNTierDbContext.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> AddRange(List<TEntity> entity)
        {
            await _aspNetCoreNTierDbContext.AddRangeAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }

        public async Task<int> Delete(TEntity entity)
        {
            _ = _aspNetCoreNTierDbContext.Remove(entity);
            return await _unitOfWork.SaveChangesAsync();

        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return await _aspNetCoreNTierDbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(filter);
        }

        public async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return await (filter == null ? _aspNetCoreNTierDbContext.Set<TEntity>().ToListAsync() : _aspNetCoreNTierDbContext.Set<TEntity>().Where(filter).ToListAsync());
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _ = _aspNetCoreNTierDbContext.Update(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> UpdateRange(List<TEntity> entity)
        {
            _aspNetCoreNTierDbContext.UpdateRange(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }
    }
}
