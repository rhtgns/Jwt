using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    public class UserLoginDto
    {
        [Authorize]
        [ApiController]
        [Route("api/[controller]")]
        public class UserController : ControllerBase
        {
            // Buradaki tüm aksiyonlar JWT doğrulaması gerektirecektir.
            [HttpGet]
            public IActionResult GetAllUsers()
            {
                // Kullanıcıları döndürür
            }

            [HttpPost]
            public IActionResult CreateUser(UserDto user)
            {
                // Yeni bir kullanıcı oluşturur
            }
        }

    }
}