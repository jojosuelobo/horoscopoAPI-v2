using consultaAstrologiaAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace consultaAstrologiaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HoroscopoController : Controller
    {
        [HttpGet(Name = "GetHoroscopoDTO")]
        public HoroscopoDTO Get()
        {
            HoroscopoDTO horoscopo = new HoroscopoDTO();
            return horoscopo;
        }

        // TESTE
    }
}
