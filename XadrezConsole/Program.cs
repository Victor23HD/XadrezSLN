using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    class Program
    {
        public static void Main()
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.terminada)
            {
                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);
                Console.Write("\nOrigem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosition();
                bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab,posicoesPossiveis);
                Console.Write("\nDestino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosition();
                partida.executarMovimento(origem, destino);

            }


        }
    }
}