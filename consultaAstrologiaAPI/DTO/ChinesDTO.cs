using System.Diagnostics;

namespace consultaAstrologiaAPI.DTO
{
    public class ChinesDTO
    {
        public string signoChines { get; set; }
        public string fraseChinesa { get; set; }

        private static readonly string[] Signos = {
        "Rato", "Boi", "Tigre", "Coelho", "Dragão", "Serpente",
        "Cavalo", "Cabra", "Macaco", "Galo", "Cão", "Porco"
        };
       
        private static readonly string[] Frases = {
        "你的太阳星座揭示了你个性的重要方面。",
        "你的上升星座影响你在世界上的呈现方式。",
        "月亮在你的星盘中的位置影响你的情感和直觉。",
        "每个星座都有自己独特的特征和特点。",
        "火象星座是白羊座、狮子座和射手座，以其激情和活力而闻名。",
        "土象星座是金牛座、处女座和摩羯座，注重稳定和实用。",
        "风象星座是双子座、天秤座和水瓶座，以其分析思维和社交能力著称。",
        "水象星座是巨蟹座、天蝎座和双鱼座，以其敏感和直觉为特征。",
        "星座之间的相容性可以用来理解人际关系。",
        "星座图是基于出生时刻行星的位置。",
        "行星运行可以指示生活中的变化和转变。",
        "咨询占星师可以帮助更好地理解你的星盘。",
        "占星预测可以提供关于爱情、事业和健康等方面的指导。",
        "每个星座都有一个主导行星，影响其主要特征。",
        "水星的逆行可能导致混乱的沟通和延迟。",
        "日食和月食对星座和整体能量产生重要影响。",
        "你的太阳星座揭示了你的本质，而月亮代表你的情感。",
        "占星学可以帮助理解行为模式和你面临的挑战。",
        "基本星座是白羊座、巨蟹座、天秤座和摩羯座，以其主动和领导能力而闻名。",
        "固定星座是金牛座、狮子座、天蝎座和水瓶座，以其稳定和毅力而著名。",
        "变动星座是双子座、处女座、射手座和双鱼座，能够轻松适应变化。",
        "你的星盘的第一宫代表你的身份和外貌。",
        "你的星盘的第七宫与关系和合作有关。",
        "你的星盘的第十宫代表你的事业和抱负。"
        }; 
        /* 
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
        "Júpiter traz sorte e expansão em"
        }; */

        public ChinesDTO()
        {
            Random random = new Random();
            int indexSigno = random.Next(0, Signos.Length);
            int indexFrase = random.Next(0, Frases.Length);
            signoChines = Signos[indexSigno];
            fraseChinesa = Frases[indexFrase];
        }

    }
}
