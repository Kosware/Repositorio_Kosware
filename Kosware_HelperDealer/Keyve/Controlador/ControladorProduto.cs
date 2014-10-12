using Keyve.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyve.Controlador
{
    public class ControladorProduto
    {
        private Produto produto;
        private List<Produto> produtos = new List<Produto>();

        internal List<Produto> Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }

        public void Cadastrar()
        {
            CarregarDadosProduto();
            produtos.Add(produto);
        }
        private void CarregarDadosProduto()
        {
            produto = new Produto();
            try {  
            Console.WriteLine("Informe a 'CATEGORIA' do produto: ");
            produto.Categoria = Console.ReadLine();
            Console.WriteLine("Informe o 'NOME' do produto: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Informe o 'PESO' do produto: ");
            produto.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 'PREÇO' do produto: ");
            produto.Preco = double.Parse(Console.ReadLine());
            } catch(Exception ex){
                Console.WriteLine("ERRO: " + ex.Message);
            }
        }
    }
}
