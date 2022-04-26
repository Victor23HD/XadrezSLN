using System;
using tabuleiro;

namespace XadrezConsole
{
    class Program
    {
        public static void Main()
        {
            Tabuleiro tabuleiro = new Tabuleiro(8,8);

            Tela.imprimirTela(tabuleiro);
        }
    }
}