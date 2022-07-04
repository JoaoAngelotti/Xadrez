using System;
using Projeto_de_Xadrez.Tabuleiro;
using Projeto_de_Xadrez.xadrez;

namespace Projeto_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
