using Bussiness.Abstract;
using Bussiness.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HavaDurumuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HavaDurumuController : ControllerBase
    {
        //dependency injecktion

        private readonly IHavaDurumuService _havaDurumuService;

        public HavaDurumuController(IHavaDurumuService havaDurumuService)
        {
            _havaDurumuService = havaDurumuService;
        }

        [HttpGet(Name = "HavaDurumuSorgula")]
        public async Task<IActionResult> HavaDurumuSorgula(string sehir)
        {
            string result = await _havaDurumuService.HavaDurumuSorgula(sehir);

            return Ok(result);  
        }
    }
}
