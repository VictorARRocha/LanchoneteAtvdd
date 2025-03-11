using Lanchonete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class Pedido
    {
        public int numeroPedido = 0;
        public List<Produto> ListaProdutos = new List<Produto>();

      

        public void MostrarPedidos()
        {
            double totalPedido = 0;
            foreach (var produto in ListaProdutos)
            {

                totalPedido += produto.PrecoProduto;

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($" - Pedido #{numeroPedido}");
            foreach (var item in ListaProdutos)
            {
                Console.WriteLine($" - {item.NomeProduto} - R${item.PrecoProduto}");
               
            }

            Console.WriteLine($"Total: R${totalPedido}");
        }







    }
}





    




