using consultaAstrologiaAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace consultaAstrologiaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanoPremiumController : Controller
    {
        [HttpGet(Name = "GetPlanoPremium")]
        public PremiumDTO Get()
        {
            PremiumDTO premium = new PremiumDTO();
            return premium;
        }
    }
}
