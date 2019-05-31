using System;
using Game.Interface;

namespace Game
{
    public class JogoFoda
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;
        private readonly IJogador _jogadorC;

        public JogoFoda(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.WriteLine(_jogadorA.Chuta());
            System.Console.WriteLine(_jogadorA.Corre());
            System.Console.WriteLine(_jogadorA.Passa());

            System.Console.WriteLine("\n Next Player");

            System.Console.WriteLine(_jogadorB.Chuta());
            System.Console.WriteLine(_jogadorB.Corre());
            System.Console.WriteLine(_jogadorB.Passa());
        }
    }
}