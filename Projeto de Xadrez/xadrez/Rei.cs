using System;
using System.Collections.Generic;
using System.Text;
using Projeto_de_Xadrez.Tabuleiro;

namespace Projeto_de_Xadrez.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro.Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
