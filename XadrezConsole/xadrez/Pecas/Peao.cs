using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "P";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;

        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] math = new bool[tab.Linhas, tab.Colunas];
            Posicao pos = new Posicao(0, 0);


            /*Primeira jogada peão*/
            if (qtdMovimentos == 0)
            {
                int i = 1;
                pos.definirValores(posicao.Linha - 1, posicao.Coluna);
                while (i <=2)
                {
                    math[pos.Linha, pos.Coluna] = true;
                    if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    {
                        break;
                    }
                   math[pos.Linha- 1, pos.Coluna] = true;
                    i++;
                }
            }

            /*Segunda jogada peão*/
            if (qtdMovimentos == 1)
            {
                pos.definirValores(posicao.Linha - 1, posicao.Coluna);
                if (tab.posicaoValida(pos) && podeMover(pos))
                {
                    math[pos.Linha, pos.Coluna] = true;
                }
            }
            return math;
        }
    }
}
