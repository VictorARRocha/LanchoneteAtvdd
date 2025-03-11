using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class GerenciarPedidos
    {
        private  List<Pedido> ListaDePedidos = new List<Pedido>();
        public int NumeroPedido = 1;


        public void AdicionarPedido(Pedido pedido)
        {

            ListaDePedidos.Add(pedido);

        }

        public void MostrarPedidos()
        {

            Console.WriteLine("Pedidos: ");
            foreach (var pedido in ListaDePedidos)
            {

                pedido.MostrarPedidos();

            }



        }



    }

}
