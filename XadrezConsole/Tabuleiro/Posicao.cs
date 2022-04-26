using System;
using System.Text;

namespace tabuleiro
{
    internal class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

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
