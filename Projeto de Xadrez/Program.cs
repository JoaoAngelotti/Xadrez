using System;
using Projeto_de_Xadrez.Tabuleiro;
using Projeto_de_Xadrez.xadrez;

namespace Projeto_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 8));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
