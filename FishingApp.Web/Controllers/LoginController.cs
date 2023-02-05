using FishingApp.Business.Services.Abstract;
using FishingApp.Entity.DTOs.Kullanici;
using Microsoft.AspNetCore.Mvc;

namespace FishingApp.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IKullaniciService _kullaniciService;

        public LoginController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost("GirisYap")]
        public async Task<IActionResult> Login(KullaniciToLoginDTO userToLoginDTO)
        {
            var kullanici = await _kullaniciService.Login(userToLoginDTO);

            if (kullanici != null)
            {
                return RedirectToAction("BirimleriListele", "Birim");
            }
            else
            {
                return View();
            }

        }
    }
}
