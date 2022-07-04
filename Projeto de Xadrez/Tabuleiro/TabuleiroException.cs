using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_de_Xadrez.Tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {
            
        }
    }
}
