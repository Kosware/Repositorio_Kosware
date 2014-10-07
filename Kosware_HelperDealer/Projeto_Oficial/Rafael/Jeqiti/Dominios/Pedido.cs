using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoProgram.Jeqiti
{
    class Pedido
    {
        public int Codigo { get; set; }
        public string DataEntrega { get; set; }
        public string DataPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public int IdVendedor { get; set; }
        public double Quantidade { get; set; }
        public double Total { get; set; }

        public Pedido()
        {

        }
    }
}
