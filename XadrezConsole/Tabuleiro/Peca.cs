using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    abstract class Peca
    {
        /*Váriaveis de classe*/
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        /*Construtor padrão*/
        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tabuleiro;
            this.qtdMovimentos = 0;
        }


        public bool existemMovimentosPossiveis()
        {
            bool[,] math = movimentosPossiveis();
            for (int i = 0; i < tab.Linhas; i++)
            {

                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (math[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void incrementarqtdMovimentos()
        {
            qtdMovimentos++;
        }
        public void decrementaMovimentos()
        {
            qtdMovimentos--;
        }
        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] movimentosPossiveis();


    }
}
