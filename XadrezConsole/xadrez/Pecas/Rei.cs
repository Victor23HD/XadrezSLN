using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "R";
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

            /*Acima*/
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                math[pos.Linha, pos.Coluna] = true;
            }
            /*Nordeste*/
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                math[pos.Linha, pos.Coluna] = true;
            }
            /*Direita*/
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                math[pos.Linha, pos.Coluna] = true;
            }
            /*Sudeste*/
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                math[pos.Linha, pos.Coluna] = true;
            }
            /*Baixo*/
            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                math[pos.Linha, pos.Coluna] = true;
            }
            /*Sudoeste*/
            pos.definirValores(posicao.Linha + 1, posicao.Coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                math[pos.Linha, pos.Coluna] = true;
            }
            /*Esquerda*/
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                math[pos.Linha, pos.Coluna] = true;
            }
            /*Noroeste*/
            pos.definirValores(posicao.Linha -1, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                math[pos.Linha, pos.Coluna] = true;
            }
            return math;
        }
    }
}
