using Game.Interface;

namespace Game.lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Pelé está chutando";
        }

        public string Corre()
        {
            return "Pelé está correndo";
        }

        public string Passa()
        {
            return "Pelé está passando";
        }
    }
}