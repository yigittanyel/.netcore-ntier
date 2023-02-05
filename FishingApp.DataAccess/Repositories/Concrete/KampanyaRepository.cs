using FishingApp.DataAccess.Context;
using FishingApp.DataAccess.Repositories.Abstract;
using FishingApp.DataAccess.UnitOfWorks.Abstract;
using FishingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.DataAccess.Repositories.Concrete
{
    public class KampanyaRepository : GenericRepository<Kampanya>, IKampanyaRepository
    {
        private readonly ApplicationDbContext _aspNetCoreNTierDbContext;
        private readonly IUnitOfWork _unitOfWork;

        public KampanyaRepository(ApplicationDbContext aspNetCoreNTierDbContext, IUnitOfWork unitOfWork) : base(aspNetCoreNTierDbContext,unitOfWork)
        {
            _aspNetCoreNTierDbContext = aspNetCoreNTierDbContext;
            _unitOfWork = unitOfWork;
        }
    }
}
