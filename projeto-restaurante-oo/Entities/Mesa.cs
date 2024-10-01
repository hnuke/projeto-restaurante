
namespace projeto_restaurante_oo.Entities{
    class Mesa{
        private static long numero = 0;
        private bool status;
        private List<Pedido> listaPedidos;

        public List<Pedido> ListaPedidos{
            get{return ListaPedidos;}
            set{}
        }

        public long Numero{
            get{return numero;}
            set{numero = value;}
        }

        public bool Status{
            get{return status;}
            set{status = value;}
        }

        // construtores

        public Mesa(){
            listaPedidos = new List<Pedido>();
            status = false;
            numero++;
        }

        // métodos
        public void RealizarPedido(List<ItemPedido> ListaItemPedido){
            listaPedidos.Add(new Pedido(ListaItemPedido));
        }

    }
}