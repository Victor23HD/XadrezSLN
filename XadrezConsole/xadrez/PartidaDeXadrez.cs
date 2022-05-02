using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int turno;
        public Cor jogadorAtual;
        public bool terminada { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Brancas;
            terminada = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            colocarPecas();
        }


        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarqtdMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
            if (pecaCapturada != null) { capturadas.Add(pecaCapturada); }
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executarMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoOrigem(Posicao origem)
        {
            if (tab.peca(origem) == null)
            {
                throw new TabuleiroException("\nNão existe peça na posição escolhida!");
            }
            if (jogadorAtual != tab.peca(origem).cor)
            {
                throw new TabuleiroException("\nA peça escolhida não é sua!");
            }
            if (!tab.peca(origem).existemMovimentosPossiveis())
            {
                throw new TabuleiroException("\nNão existem movimentos possiveis para essa peça!");
            }
        }

        public void validarPosicaoDestino(Posicao origem, Posicao destino)
        {

            if (!tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Sua peça não pode mover para esse destino!");
            }


        }

        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Brancas)
            {
                jogadorAtual = Cor.Pretas;
            }
            else
            {
                jogadorAtual = Cor.Brancas;
            }
        }

        public HashSet<Peca> pecasCapturadas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
                if (x.cor == cor) { aux.Add(x); }
            }
            return aux;
        }
        public HashSet<Peca> pecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in pecas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;

        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca)
        {
            tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosition());
            pecas.Add(peca);
        }



        private void colocarPecas()
        {

            /*Peão*/
            /*  for (int i = 0; i < 8; i++)
           {
               string texto = "a,b,c,d,e,f,g,h";
               string[] letras = texto.Split(',');
               char[] cc = new char[8];
               cc[i] = char.Parse(letras[i]);
               colocarNovaPeca(cc[i],3, new Peao(tab, Cor.Brancas));

           }*/
            /*Brancas*/
            colocarNovaPeca('c', 1, new Torre(tab, Cor.Brancas));
            colocarNovaPeca('c', 2, new Torre(tab, Cor.Brancas));
            colocarNovaPeca('d', 2, new Torre(tab, Cor.Brancas));
            colocarNovaPeca('d', 1, new Rei(tab, Cor.Brancas));
            colocarNovaPeca('e', 1, new Torre(tab, Cor.Brancas));
            colocarNovaPeca('e', 2, new Torre(tab, Cor.Brancas));


            /*Pretas*/

            colocarNovaPeca('c', 8, new Torre(tab, Cor.Pretas));
            colocarNovaPeca('c', 7, new Torre(tab, Cor.Pretas));
            colocarNovaPeca('d', 7, new Torre(tab, Cor.Pretas));
            colocarNovaPeca('d', 8, new Rei(tab, Cor.Pretas));
            colocarNovaPeca('e', 8, new Torre(tab, Cor.Pretas));
            colocarNovaPeca('e', 7, new Torre(tab, Cor.Pretas));
        }
    }
}
