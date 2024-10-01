

namespace projeto_restaurante_oo.Entities{
    class Produto{
        private static long codigo = 0;
        private string descricao;
        private int estoque;
        private double preco;
        private List<Ingrediente> listaIngredientes;

        public double Preco { get => preco; set => preco = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public Produto(List<Ingrediente> listaIngredientes, string descricao, int estoque, double preco){
            this.listaIngredientes = new List<Ingrediente>();
            this.listaIngredientes = listaIngredientes;
            this.descricao = descricao;
            this.estoque = estoque;
            this.preco = preco;


        }
            public Produto(string descricao, int estoque, double preco){
            this.descricao = descricao;
            this.estoque = estoque;
            this.preco = preco;


        }
    
    }
}