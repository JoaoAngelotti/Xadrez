using System;
using System.Collections.Generic;
using System.Text;
using Projeto_de_Xadrez.Tabuleiro;

namespace Projeto_de_Xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro.Tabuleiro tab)
        {
            for(int i = 0; i < tab.Linhas; i++)
            {
                for(int j = 0; j < tab.Colunas; j++)
                {
                    if(tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
