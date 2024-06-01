using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JN_WEB_TEST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        [Route("ConsultarUsuarios")]
        public IActionResult ConsultarUsuarios()
        {
            var x = true;

            if (x)
            {
                return NotFound("No se encontro el registro");
            }

            return Ok("Todo bien");
        }

    }
}
