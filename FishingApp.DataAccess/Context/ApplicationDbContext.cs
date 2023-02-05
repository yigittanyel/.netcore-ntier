using FishingApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Birim> Birims { get; set; } 
        public DbSet<Grup> Grups { get; set; } 
        public DbSet<Kampanya> Kampanyas { get; set; } 
        public DbSet<KampanyaSonuc> KampanyaSonucs { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Sablon> Sablons { get; set; }
    }
}
