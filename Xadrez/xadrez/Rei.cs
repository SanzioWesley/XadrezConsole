using tabuleiro;
namespace xadrez
{
    class Rei : Peca
    {
        /*O construtor Rei, recebendo (Tabuleiro tab, Cor cor) 
          esta repassando a instrução para a classe Peca*/
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

            public override string ToString()
        {
            return "R";
        }
    }
}

