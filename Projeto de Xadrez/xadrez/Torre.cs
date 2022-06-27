using System;
using System.Collections.Generic;
using System.Text;
using Projeto_de_Xadrez.Tabuleiro;

namespace Projeto_de_Xadrez.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro.Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
