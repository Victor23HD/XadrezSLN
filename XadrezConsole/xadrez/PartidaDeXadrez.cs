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

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Brancas;
            terminada = false;
            colocarPecas();
        }

        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarqtdMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
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

        public void validarPosicaoDestino(Posicao origem,Posicao destino)
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

        private void colocarPecas()
        {
            /*tab.colocarPeca(new Peao(tab, Cor.Brancas), new PosicaoXadrez('a', 2).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Brancas), new PosicaoXadrez('b', 2).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Brancas), new PosicaoXadrez('c', 2).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Brancas), new PosicaoXadrez('d', 2).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Brancas), new PosicaoXadrez('e', 2).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Brancas), new PosicaoXadrez('f', 2).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Brancas), new PosicaoXadrez('g', 2).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Brancas), new PosicaoXadrez('h', 2).toPosition());*/
            tab.colocarPeca(new Torre(tab, Cor.Brancas), new PosicaoXadrez('a', 1).toPosition());
            tab.colocarPeca(new Torre(tab, Cor.Brancas), new PosicaoXadrez('h', 1).toPosition());
            tab.colocarPeca(new Rei(tab, Cor.Brancas), new PosicaoXadrez('d', 1).toPosition());

            /*tab.colocarPeca(new Peao(tab, Cor.Pretas), new PosicaoXadrez('a', 7).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Pretas), new PosicaoXadrez('b', 7).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Pretas), new PosicaoXadrez('c', 7).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Pretas), new PosicaoXadrez('d', 7).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Pretas), new PosicaoXadrez('e', 7).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Pretas), new PosicaoXadrez('f', 7).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Pretas), new PosicaoXadrez('g', 7).toPosition());
            tab.colocarPeca(new Peao(tab, Cor.Pretas), new PosicaoXadrez('h', 7).toPosition());*/
            tab.colocarPeca(new Torre(tab, Cor.Pretas), new PosicaoXadrez('a', 8).toPosition());
            tab.colocarPeca(new Torre(tab, Cor.Pretas), new PosicaoXadrez('h', 8).toPosition());
            tab.colocarPeca(new Rei(tab, Cor.Pretas), new PosicaoXadrez('d', 8).toPosition());
        }
    }
}
