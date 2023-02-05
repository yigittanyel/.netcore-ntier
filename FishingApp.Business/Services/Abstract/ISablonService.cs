using FishingApp.Entity.DTOs.Kullanici;
using FishingApp.Entity.DTOs.Sablon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Business.Services.Abstract
{
    public interface ISablonService
    {
        Task<List<SablonDTO>> GetSablons();
        Task<SablonDTO> GetSablon(int sablonId);
        Task<SablonDTO> AddSablon(SablonToAddDTO sablonToAddDTO);
        Task<SablonDTO> UpdateSablon(SablonToUpdateDTO sablonToUpdateDTO);
        Task DeleteSablon(int sablonId);
    }
}
