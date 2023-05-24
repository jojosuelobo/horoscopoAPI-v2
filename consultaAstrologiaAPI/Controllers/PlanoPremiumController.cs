using consultaAstrologiaAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace consultaAstrologiaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanoPremiumController : Controller
    {
        private static readonly string[] UsersPremium = {
        "gabriel", "josue", "caio", "vinicius", "felca"
        };

        [HttpGet(Name = "GetPlanoPremium")]
        public PremiumDTO Get(string user)
        {
            for(int i = 0; i < UsersPremium.Length; i++)
            {
                if(user == UsersPremium[i])
                {
                    PremiumDTO premium = new PremiumDTO();
                    return premium;
                }
            }
            PremiumDTO premiumFake = new PremiumDTO(false);
            return premiumFake;
        }
    }
}
