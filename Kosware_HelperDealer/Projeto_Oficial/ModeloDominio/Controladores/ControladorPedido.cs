using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kosware_Helper_Dealer.Entidades;

namespace Projeto_Oficial.ModeloDominio.Controladores
{
    class ControladorPedido
    {
        private Pedido pedido;
        private List<Pedido> pedidos = new List<Pedido>();

        internal List<Pedido> Pedidos
        {
            get { return pedidos; }
            set { pedidos = value; }
        }


    }
}
