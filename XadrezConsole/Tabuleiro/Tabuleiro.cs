using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez;

namespace tabuleiro
{
    class Tabuleiro
    {   
        /*Váriaveis de classe*/
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] pecas;


        /*Construtor padrão*/
        public Tabuleiro(int Linhas, int Colunas)
        {
            this.Linhas = Linhas;
            this.Colunas = Colunas;
            pecas = new Peca[Linhas,Colunas];
        }

        /*Metodo para retornar a posição da peça, com base no Program.cs*/
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        /*Metodo para colocar a peça*/
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (pecaExiste(pos))
            {
                throw new TabuleiroException("Já existe uma peça");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }

        /*Valida se a peça existe com base em 2 metodos*/
        public bool pecaExiste(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        /*Metodo para validar se a posição existe*/
        public bool posicaoValida(Posicao pos)
        {
            if (pos.Linha <0 || pos.Linha >=8 || pos.Coluna <0 || pos.Coluna >=8)
            {
                return false;
            }
            return true;
        }

        /*Metodo para validar a posição*/
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição invalida!");
            }
        }
       
    }
}
