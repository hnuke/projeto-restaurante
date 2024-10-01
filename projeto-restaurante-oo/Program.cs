using projeto_restaurante_oo.Entities;

namespace projeto_restaurante_oo
{
    class Program{
        public static void Main(String[] args){

            //criação de ingredientes
            Ingrediente i = new Ingrediente("Alho caseiro",2,1.2,10);
            Ingrediente i2 = new Ingrediente("Tomate",4,2.5,10);
            //criação de produtos
            Produto p1 = new Produto("Alho com tomate",2,40);
            Produto p2 = new Produto("Tomate", 2, 50);

            //criação da mesa
            Mesa mesa = new Mesa();
            //itens da mesa
            ItemPedido itempedido1 = new ItemPedido(2,25,p1);
            List<ItemPedido> listaItem = new List<ItemPedido>();
            listaItem.Add(itempedido1);
            //pedido da mesa
            mesa.RealizarPedido(listaItem);

            

        }
    }
}