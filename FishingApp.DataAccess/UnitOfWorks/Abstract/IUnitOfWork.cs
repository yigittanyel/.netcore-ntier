using FishingApp.Core.Primitives;
using FishingApp.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.DataAccess.UnitOfWorks.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task<int> SaveChangesAsync();
    }
}
