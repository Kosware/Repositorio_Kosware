using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kosware_Helper_Dealer.Entidades;

namespace Projeto_Oficial.ModeloDominio.Controladores
{
    class ControladorVendedor
    {
        private Cliente cliente;
        private List<Cliente> clientes = new List<Cliente>();

        internal List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }


    }
}
