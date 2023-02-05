using FishingApp.Entity.DTOs.Kampanya;
using FishingApp.Entity.DTOs.KampanyaSonuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Business.Services.Abstract
{
    public interface IKampanyaSonucService
    {
        Task<List<KampanyaSonucDTO>> GetKampanyaSonucs();
        Task<KampanyaSonucDTO> GetKampanyaSonuc(int kampanyaSonucId);
        Task<KampanyaSonucDTO> AddKampanyaSonuc(KampanyaSonucToAddDTO kampanyaSonucToAddDTO);
        Task<KampanyaSonucDTO> UpdateKampanyaSonuc(KampanyaSonucToUpdateDTO kampanyaSonucToUpdateDTO);
        Task DeleteKampanyaSonuc(int kampanyaSonucId);
    }
}
