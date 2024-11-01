using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoXadrez.tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas;
        public int colunas;
        public Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this.pecas = new Peca[linhas, colunas];
        }

        public Peca peca(Posicao posicao)
        {
            return pecas[posicao.linha, posicao.coluna];
        }

        public void colocarPeca(Peca peca, Posicao posicao)
        {
            if (existePeca(posicao))
            {
                throw new TabuleiroException("Peca ja existe na posicao!");
            }
            pecas[posicao.linha, posicao.coluna] = peca;
            peca.posicao = posicao;
        }

        public Peca retirarPeca(Posicao posicao)
        {
            if (peca(posicao) == null)
            {
                return null;
            }
            Peca aux = peca(posicao);
            aux.posicao = null;
            pecas[posicao.linha, posicao.coluna] = null;

            return aux;
        }

        public bool existePeca(Posicao posicao)
        {
            validaPosicao(posicao);
            return peca(posicao) != null;
        }

        public bool posicaoValida(Posicao posicao)
        {
            if (posicao.linha < 0 || posicao.linha >= linhas || posicao.coluna < 0 || posicao.coluna >= colunas)
            {
                return false;
            }

            return true;
        }

        public void validaPosicao(Posicao posicao)
        {
            if (!posicaoValida(posicao))
            {
                throw new TabuleiroException("Posicao Invalida!");
            }
        }
    }
}
