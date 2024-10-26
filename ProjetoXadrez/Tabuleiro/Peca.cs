using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoXadrez.tabuleiro
{
    internal class Peca
    {
        public Cor cor;
        public Posicao posicao;
        public Tabuleiro tabuleiro;
        public int qtdMovimentos;

        public Peca(Cor cor, Posicao posicao, Tabuleiro tabuleiro)
        {
            this.cor = cor;
            this.posicao = posicao;
            this.tabuleiro = tabuleiro;
            qtdMovimentos = 0;
        }
    }
}
