using System;
using Game.Interface;

namespace Game.lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Name;

        public Jogador1(string name = "Thiago")
        {
            _Name = name;
        }

        public string Chuta()
        {
            return $"{_Name} está Chutando";
        }

        public string Passa()
        {
            return $"{_Name} está Passando";
        }

        public string Corre()
        {
            return $"{_Name} está Correndo";
        }
    }
}