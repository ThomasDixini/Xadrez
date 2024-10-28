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

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.cor = cor;
            this.posicao = null;
            this.tabuleiro = tabuleiro;
            qtdMovimentos = 0;
        }
    }
}
