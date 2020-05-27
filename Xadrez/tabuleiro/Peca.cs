namespace tabuleiro
{
    //class Peca is generic class can be any part
    class Peca
    {
        public Posicao posicao { get; set; }
        //can be changed by itself or by the subclass
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        /*part builder,
        every piece starts in the null position with qteMovimento receives 0*/
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qtdMovimentos = 0;
        }
    }
}
