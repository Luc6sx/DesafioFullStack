using Microsoft.AspNetCore.Mvc;
using DesafioFullStackAPI.Services;
using DesafioFullStackFront.Models;

namespace DesafioFullStackAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PilotosController : ControllerBase
    {
      

        public PilotosController()
        {
           
        }

        [HttpGet("piloto")]
        public IActionResult GetPilotos()
        {
            
            PilotoService service = new PilotoService();
            List<Piloto> pilotos = service.GetPilotos();

            return Ok(pilotos);
            
            
        }
    }
}
