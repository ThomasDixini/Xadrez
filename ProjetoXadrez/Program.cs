using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.xadrez;

namespace ProjetoXadrez
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
            tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(1, 2));

            Tela.ImprimeTabuleiro(tab);
        }
    }
}