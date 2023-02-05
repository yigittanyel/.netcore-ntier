using FishingApp.Entity.DTOs.Birim;
using FishingApp.Entity.DTOs.Grup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Business.Services.Abstract
{
    public interface IGrupService
    {
        Task<List<GrupDTO>> GetGrups();
        Task<GrupDTO> GetGrup(int grupId);
        Task<GrupDTO> AddGrup(GrupToAddDTO grupToAddDTO);
        Task<GrupDTO> UpdateGrup(BirimToUpdateDTO grupToUpdateDTO);
        Task DeleteGrup(int grupId);
    }
}
