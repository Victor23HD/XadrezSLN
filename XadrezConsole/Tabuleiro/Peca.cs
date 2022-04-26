using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; protected set; }
        public Cor cor { get; set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.qtdMovimentos = 0;
        }

       

    }
}
