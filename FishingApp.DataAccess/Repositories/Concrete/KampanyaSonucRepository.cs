﻿using FishingApp.DataAccess.Context;
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
    public class KampanyaSonucRepository : GenericRepository<KampanyaSonuc>, IKampanyaSonucRepository
    {
        private readonly ApplicationDbContext _aspNetCoreNTierDbContext;
        private readonly IUnitOfWork _unitOfWork;

        public KampanyaSonucRepository(ApplicationDbContext aspNetCoreNTierDbContext, IUnitOfWork unitOfWork) : base(aspNetCoreNTierDbContext,unitOfWork)
        {
            _aspNetCoreNTierDbContext = aspNetCoreNTierDbContext;
            _unitOfWork = unitOfWork;
        }
    }
}