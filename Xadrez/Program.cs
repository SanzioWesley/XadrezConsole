using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //instantiate a new variable
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 1));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 1));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 2));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 4));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 5));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 6));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 7));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 0));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 1));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 2));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 3));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 4));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 6));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 7));


                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}