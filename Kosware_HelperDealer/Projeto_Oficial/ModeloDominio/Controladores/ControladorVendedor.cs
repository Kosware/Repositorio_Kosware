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
        private Cliente vendedor;
        private List<Cliente> vendedores = new List<Cliente>();

        internal List<Cliente> Vendedores
        {
            get { return vendedores; }
            set { vendedores = value; }
        }


    }
}
