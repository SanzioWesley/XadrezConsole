namespace tabuleiro
{
    //to show which row and column the part is in
    class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //Returns a string that represents the current object
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
