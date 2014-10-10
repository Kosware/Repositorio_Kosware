using Kosware_Helper_Dealer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arnaldo.ModeloDominio.Controladores
{
    class GeradorRelatórios
    {
        public static void ObterPedidos(List<Pedido> pedidos)
        {
            foreach (Pedido pedido in pedidos)
            {
                MostrarDados(pedido);
            }
        }

        public static void MostrarDados(Pedido pedido)
        {
            
        }
    }
}
