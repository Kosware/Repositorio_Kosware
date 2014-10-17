using Kosware_Helper_Dealer.Entidades;
using System.Collections.Generic;

namespace Projeto_Oficial.ModeloDominio.Controladores
{
    internal class ControladorProduto
    {
        private Produto produto;
        private List<Produto> produtos = new List<Produto>();

        internal List<Produto> Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }

        public int Pesquisa(int codigo)
        {
            int posicao = -1;

            for (int i = 0; i < this.produtos.Count; i++)
            {
                if (codigo == produtos[i].Codigo)
                {
                    posicao = i;
                    break;
                }
            }

            return posicao;
        }
    }
}