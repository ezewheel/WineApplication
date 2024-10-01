using Common.DTOs;
using Microsoft.AspNetCore.Mvc;
using Services.WineServices;

namespace WineApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : Controller
    {
        private readonly IWineService _wineService;

        public WineController(IWineService wineService)
        {
            _wineService = wineService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_wineService.getWines());
        }

        [HttpPost]
        public IActionResult AddWine([FromBody] WineForAddDto newWine)
        {
            _wineService.addWine(newWine);
            return Ok(_wineService.getWines());
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult CreateUser([FromBody] UserForAddDto newUser)
        {
            _wineService.createUser(newUser);
            return Ok(newUser);
        }
    }
}
