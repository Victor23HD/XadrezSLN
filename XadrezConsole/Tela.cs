using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace XadrezConsole
{
     class Tela
    {

        public static void imprimirTela(Tabuleiro Tab)
        {
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (Tab.peca(i,j) == null)
                    {
                        Console.Write(" -");
                    }
                    else
                    {
                        Console.Write(Tab.peca(i,j)+" ");
                    }

                    
                }
                Console.WriteLine();
            }
        }


    }
}
