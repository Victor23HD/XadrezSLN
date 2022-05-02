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
                    Tela.imprimirPartida(partida);
                    

                }catch (TabuleiroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }

            }


        }
    }
}