using Microsoft.AspNetCore.Mvc;

namespace consultaAstrologiaAPI.DTO
{
    public class PremiumDTO : Controller
    {
        //public ChinesDTO Chines { get; set; }
        //public HoroscopoDTO Horoscopo { get; set;}
        public string signoChines { get; set; }
        public string signo { get; set; }   
        public string fraseChinesa { get; set; }
        public string frase { get; set; }

        public PremiumDTO()
        {
            HoroscopoDTO horoscopo = new HoroscopoDTO();
            ChinesDTO chines = new ChinesDTO();
            signoChines = chines.signoChines;
            fraseChinesa = chines.fraseChinesa;

            signo = horoscopo.signo;
            frase = horoscopo.frase;
        }
    }
}
