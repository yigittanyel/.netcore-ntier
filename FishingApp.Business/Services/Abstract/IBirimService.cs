using FishingApp.Entity.DTOs.Birim;
using FishingApp.Entity.DTOs.Kullanici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Business.Services.Abstract
{
    public interface IBirimService
    {
        Task<List<BirimDTO>> GetBirims();
        Task<BirimDTO> GetBirim(int birimId);
        Task<BirimDTO> AddBirim(BirimToAddDTO birimToAddDTO);
        Task<BirimDTO> UpdateBirim(BirimToUpdateDTO birimToUpdateDTO);
        Task DeleteBirim(int birimId);
    }
}
