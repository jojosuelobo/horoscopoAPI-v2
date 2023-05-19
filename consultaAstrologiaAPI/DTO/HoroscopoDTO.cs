namespace consultaAstrologiaAPI.DTO
{
    public class HoroscopoDTO
    {
        public string signo { get; set; }

        private static readonly string[] Signos = {
        "Áries", "Touro", "Gêmeos", "Câncer", "Leão", "Virgem",
        "Libra", "Escorpião", "Sagitário", "Capricórnio", "Aquário", "Peixes"
        };

        public HoroscopoDTO()
        {
            Random random = new Random();
            int index = random.Next(0, Signos.Length);
            signo = Signos[index];
        }

    }
}
