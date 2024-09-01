using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Radore_JWT.Models;
using Radore_JWT.Services.User;

namespace Radore_JWT.Controllers
{
    [Route("api/[controller]/[action]")]
    [Authorize]
    [ApiController]
    public class SamplesController : ControllerBase
    {
        private static readonly string[] sehirler = 
        {
            "Ankara", "İstanbul", "İzmir", "Adana", "Antalya", "Bursa", "Eskişehir", "Gaziantep", "Konya", "Mersin", "Samsun", "Trabzon"
        };

        private readonly IUserService _userService;

        public SamplesController(IUserService userService) => _userService = userService;

        [HttpGet]
        public IActionResult GetSehirler() => Ok(sehirler);

        //Burada da AllowAnonymous attribute nü kullanarak bu seferde bu metoda herkesin erişebileceğini söylüyoruz.
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate([FromBody] AuthenticationModel authenticateModel)
        {
            var user = _userService.Authenticate(authenticateModel.UserName, authenticateModel.Password);

            if (user == null)
                return BadRequest("Username ve şifre hatalı!");

            return Ok(new { Username = user.Value.username, Token = user.Value.token });
        }

    }
}
