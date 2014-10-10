using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kosware_Helper_Dealer.Entidades;
using System.Threading.Tasks;

namespace Projeto_Oficial.ModeloDominio.Controladores
{
    class ControladorProduto
    {
        private Produto produto;
        private List<Produto> produtos = new List<Produto>();

        internal List<Produto> Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }
    }
}
