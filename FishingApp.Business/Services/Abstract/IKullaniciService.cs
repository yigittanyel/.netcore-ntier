using FishingApp.Entity.DTOs.Birim;
using FishingApp.Entity.DTOs.Kullanici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Business.Services.Abstract
{
    public interface IKullaniciService
    {
        Task<List<KullaniciDTO>> GetKullanicis();
        Task<KullaniciDTO> GetKullanici(int kullaniciId);
        Task<KullaniciDTO> AddKullanici(KullaniciToAddDTO kullaniciToAddDTO);
        Task<KullaniciDTO> UpdateKullanici(KullaniciToUpdateDTO kullaniciToUpdateDTO);
        Task DeleteKullanici(int kullaniciId);
        Task<KullaniciDTO> Login(KullaniciToLoginDTO kullaniciToLoginDTO);
        Task<KullaniciDTO> Register(KullaniciToRegisterDTO kullaniciToRegisterDTO);
    }
}
