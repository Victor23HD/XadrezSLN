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

        /*ToString() teste, vai ser morto no futuro*/
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("L:");
            sb.Append(Linha);
            sb.Append(" C:");
            sb.AppendLine(Coluna.ToString());

            return sb.ToString();
        }
    }
}
