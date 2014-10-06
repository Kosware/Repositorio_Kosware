using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosware_Helper_Dealer.Entidades
{
    class Pedido
    {
        public int Codigo { get; set; }
        public DateTime DataEntrega { get; set; }
        public DateTime DataPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }
    }
}
