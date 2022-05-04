using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;



namespace XadrezConsole
{
    class Tela
    {

        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("\nPecas capturadas: ");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Brancas));
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Pretas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Pretas));
            Console.ForegroundColor = aux;
        }

        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");

            foreach (Peca x in conjunto)
            {
                Console.Write(x + ", ");
            }

            Console.WriteLine("]");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.Linhas; i++)
            {
                ConsoleColor n1 = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(8 - i + " ", n1);
                Console.ForegroundColor = n1;
                
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            ConsoleColor n2 = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  A B C D E F G H", n2);
            Console.ForegroundColor = n2;
        }

        /*For para percorrer a matriz e imprimir o tabuleiro na tela*/
        public static void imprimirTabuleiro(Tabuleiro Tab)
        {
            Console.WriteLine("Se gostou me siga nos links abaixo!");
            Console.WriteLine("GitHub: https://github.com/Victor23HD");
            Console.WriteLine("Lindedin: www.linkedin.com/in/victor23hd \n");
            for (int i = 0; i < Tab.Linhas; i++)
            {
                ConsoleColor n1 = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(8 - i + " ", n1);
                Console.ForegroundColor = n1;

                for (int j = 0; j < Tab.Colunas; j++)
                {
                    imprimirPeca(Tab.peca(i, j));
                }
                Console.WriteLine();
            }
            ConsoleColor n2 = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  A B C D E F G H", n2);
            Console.ForegroundColor = n2;

        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        /*Imprimir peças pretas e brancas*/
        public static void imprimirPeca(Peca peca)
        {

            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Brancas)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }

        }


    }

}


