

namespace projeto_restaurante_oo.Entities{
    class Pedido{
        private static long numero = 0;
        private DateTime horario;
        private double total;

        private List<ItemPedido> listaItem;

        public List<ItemPedido> ListaItem{
            get{return listaItem;}
            set{}
        }

        public DateTime Horario{
            get{return horario;}
            set{horario = value;}
        }

        public double Total{
            get{return total;}
            set{total = value;}
        }

        // construtor
        public Pedido(List<ItemPedido> listaPedidos){
            this.horario = DateTime.Now;
            listaItem = new List<ItemPedido>();
            listaPedidos.ForEach(a => listaItem.Add(a));
            numero++; 
        }
    }
}