using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    class Program
    {
        public static void Main()
        {
              try
              {
                  Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                  tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(0, 1));
                  tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 5));
                  Posicao pos = new Posicao(0, 5);
                  tabuleiro.pecaExiste(pos);

                  Tela.imprimirTabuleiro(tabuleiro);
              }
              catch (Exception e)
              {
                  Console.WriteLine(e.Message);
              }

        }
    }
}