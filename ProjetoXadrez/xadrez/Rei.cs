using ProjetoXadrez.tabuleiro;

namespace ProjetoXadrez.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }

    }
}
