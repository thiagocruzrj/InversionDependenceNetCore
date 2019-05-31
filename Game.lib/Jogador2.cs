using Game.Interface;

namespace Game.lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona está chutando";
        }

        public string Corre()
        {
            return "Maradona está corrento";
        }

        public string Passa()
        {
            return "Maradona está passando";
        }
    }
}