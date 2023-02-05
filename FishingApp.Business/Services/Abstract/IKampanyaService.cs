using FishingApp.Entity.DTOs.Birim;
using FishingApp.Entity.DTOs.Grup;
using FishingApp.Entity.DTOs.Kampanya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Business.Services.Abstract
{
    public interface IKampanyaService
    {
        Task<List<KampanyaDTO>> GetKampanyas();
        Task<KampanyaDTO> GetKampanya(int kampanyaId);
        Task<KampanyaDTO> AddKampanya(KampanyaToAddDTO kampanyaToAddDTO);
        Task<KampanyaDTO> UpdateKampanya(KampanyaToUpdateDTO kampanyaToUpdateDTO);
        Task DeleteKampanya(int kampanyaId);
    }
}
