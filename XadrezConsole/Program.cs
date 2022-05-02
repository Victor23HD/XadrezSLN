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

                try
                {   /*Imprime o tabuleiro*/
                    Console.Clear();
              
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine($"\nTurno: {partida.turno} \nJogador atual: {partida.jogadorAtual.ToString()}");

                    /*Pede a peça de origem.*/
                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosition();
                    partida.validarPosicaoOrigem(origem);
                    /*Lê os movimentos possiveis*/
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    /*Imprime o tabuleiro com os movimentos possiveis e pede o destino das peças*/
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                    Console.Write("\nDestino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosition();
                    partida.validarPosicaoDestino(origem, destino);
                    partida.realizaJogada(origem, destino);

                }catch (TabuleiroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }

            }


        }
    }
}