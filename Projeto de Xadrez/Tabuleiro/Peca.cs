using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_de_Xadrez.Tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            QteMovimentos = 0;
            this.tab = tab;
        }

        public void incrementarQtdeMovimentos()
        {
            QteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
