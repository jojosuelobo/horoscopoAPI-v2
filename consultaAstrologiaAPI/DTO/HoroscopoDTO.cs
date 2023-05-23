namespace consultaAstrologiaAPI.DTO
{
    public class HoroscopoDTO
    {
        public string signo { get; set; }
        public string frase { get; set; }

        private static readonly string[] Signos = {
        "Áries", "Touro", "Gêmeos", "Câncer", "Leão", "Virgem",
        "Libra", "Escorpião", "Sagitário", "Capricórnio", "Aquário", "Peixes"
        };

        private static readonly string[] Frases = {
        "Seu signo solar revela aspectos importantes da sua personalidade.",
        "As características do seu ascendente influenciam a forma como você se apresenta ao mundo.",
        "A posição da Lua no seu mapa astral afeta suas emoções e intuição.",
        "Cada signo tem suas próprias características e traços distintos.",
        "Os signos de fogo são Áries, Leão e Sagitário, conhecidos por sua paixão e energia.",
        "Os signos de terra são Touro, Virgem e Capricórnio, valorizando estabilidade e praticidade.",
        "Os signos de ar são Gêmeos, Libra e Aquário, destacando-se pela mente analítica e sociabilidade.",
        "Os signos de água são Câncer, Escorpião e Peixes, caracterizados por sua sensibilidade e intuição.",
        "A compatibilidade entre signos pode ser explorada para entender relacionamentos.",
        "O horóscopo é baseado na posição dos planetas no momento do seu nascimento.",
        "Os trânsitos planetários podem indicar períodos de mudança e transformação em sua vida.",
        "Consultar um astrólogo pode ajudar a compreender melhor o seu mapa astral.",
        "As previsões astrológicas podem fornecer orientação sobre aspectos da vida, como amor, carreira e saúde.",
        "Cada signo tem um planeta regente que influencia suas características principais.",
        "A energia retrógrada de Mercúrio pode causar comunicação confusa e atrasos.",
        "Os eclipses solares e lunares têm um impacto significativo no horóscopo e na energia geral.",
        "Seu signo solar indica sua essência, enquanto a lua representa suas emoções.",
        "A astrologia pode ajudar a compreender os padrões comportamentais e os desafios que você enfrenta.",
        "Os signos cardinais são Áries, Câncer, Libra e Capricórnio, conhecidos por sua iniciativa e liderança.",
        "Os signos fixos são Touro, Leão, Escorpião e Aquário, destacando-se pela estabilidade e perseverança.",
        "Os signos mutáveis são Gêmeos, Virgem, Sagitário e Peixes, adaptando-se facilmente às mudanças.",
        "A casa 1 do seu mapa astral representa sua identidade e aparência física.",
        "A casa 7 do seu mapa astral está relacionada aos relacionamentos e parcerias.",
        "A casa 10 do seu mapa astral representa sua carreira e ambições.",
        "A compatibilidade entre signos de fogo e ar é geralmente estimulante e cheia de entusiasmo.",
        "Os signos de terra e água tendem a ter uma conexão emocional mais profunda e estável.",
        "O signo ascendente descreve a primeira impressão que você causa nas pessoas.",
        "A energia de Marte representa a ação e a paixão em sua vida.",
        "Vênus influencia seus relacionamentos amorosos e sua apreciação pela beleza.",
        "Júpiter traz sorte e expansão em seu coração >w<"
        };

        public HoroscopoDTO()
        {
            Random random = new Random();
            int indexSigno = random.Next(0, Signos.Length);
            int indexFrase = random.Next(0, Frases.Length);
            signo = Signos[indexSigno];
            frase = Frases[indexFrase];
        }

    }
}
