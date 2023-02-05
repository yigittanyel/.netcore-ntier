using FishingApp.DataAccess.Context;
using FishingApp.DataAccess.Repositories.Abstract;
using FishingApp.DataAccess.Repositories.Concrete;
using FishingApp.DataAccess.UnitOfWorks.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.DataAccess.UnitOfWorks.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
           return await dbContext.SaveChangesAsync();
        }
    }
}
