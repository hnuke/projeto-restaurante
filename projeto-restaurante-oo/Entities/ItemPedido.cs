

namespace projeto_restaurante_oo.Entities{
    class ItemPedido{
        private int quantidade;
        private double preco;
        private double subtotal;
        private Produto produtoReferencia;

        public int Quantidade{
            get{return quantidade;}
            set{quantidade = value;}
        }

        public double Preco{
            get{return preco;}
            set{preco = value;}
        }

        public double Subtotal{
            get{return subtotal;}
            set{subtotal = value;}
        }

        public Produto ProdutoReferencia { get => produtoReferencia; set => produtoReferencia = value; }

        public ItemPedido(int quantidade, double preco,Produto produto){
            produtoReferencia = produto;
            this.quantidade = quantidade;
            this.preco = produtoReferencia.Preco;
            this.subtotal = preco * quantidade;
        }
    }
}