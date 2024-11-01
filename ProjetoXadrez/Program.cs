using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.xadrez;

namespace ProjetoXadrez
{
    class Program
    {
        public static void Main(string[] args)
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            Tela.ImprimeTabuleiro(partida.tab);
        }
    }
}