using System;
using Projeto_de_Xadrez.Tabuleiro;

namespace Projeto_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
