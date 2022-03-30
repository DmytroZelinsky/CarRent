using CarRent.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IJwtService _jwtService;

        public AdminController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpGet]
        public ActionResult<string> Authenticate(string adminPassword)
        {
            return Ok(_jwtService.GetAdminJwtToken(adminPassword));
        }

    }
}
