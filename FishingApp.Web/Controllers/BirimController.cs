using FishingApp.Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FishingApp.Web.Controllers
{
    public class BirimController : Controller
    {
        private readonly IBirimService _birimService;

        public BirimController(IBirimService birimService)
        {
            _birimService = birimService;
        }

        public async Task<IActionResult> BirimleriListele()
        {
            var birimListesi = await _birimService.GetBirims();
            return View(birimListesi);
        }
    }
}
