using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.xadrez;

namespace ProjetoXadrez
{
    class Program
    {
        public static void Main(string[] args)
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            

            while(!partida.terminada)
            {
                Console.Clear();
                Tela.ImprimeTabuleiro(partida.tab);

                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.executaMovimento(origem, destino);
            }
        }
    }
}