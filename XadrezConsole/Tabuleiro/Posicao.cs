using System;
using System.Text;

namespace tabuleiro
{
    internal class Posicao
    {   
        /*Váriaveis de classe*/
        public int Linha { get; set; }
        public int Coluna { get; set; }


        /*Construtor padrão*/
        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
        public void definirValores(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha + ", " +Coluna;
        }

    }
}
