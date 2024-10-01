
namespace projeto_restaurante_oo.Entities{
    class Ingrediente : Produto
    {
        private int quantidade;
        
        public Ingrediente(string descricao, int estoque, double preco, int quantidade) : base(descricao, estoque, preco)
        {
            this.Quantidade = quantidade;
        }

        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}