using ProjetoXadrez.tabuleiro;

namespace ProjetoXadrez
{
    internal class Tela
    {
        public static void ImprimeTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.pecas[i, j] == null)
                    {
                        Console.Write("-" + " ");
                    }
                    Console.Write(tab.pecas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
