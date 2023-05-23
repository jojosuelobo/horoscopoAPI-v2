using consultaAstrologiaAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace consultaAstrologiaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanoBasicoController : Controller
    {
        [HttpGet(Name = "GetPlanoBasico")]
        public HoroscopoDTO Get()
        {
            HoroscopoDTO horoscopo = new HoroscopoDTO();
            return horoscopo;
        }
    }
}
