using Kosware_Helper_Dealer.Entidades;
using System;
using System.Collections.Generic;

namespace Keyve.ModeloDeDominio.Controladores
{
    class ControladorProduto
    {
        private Produto produto;
        private List<Produto> produtos = new List<Produto>();

        public List<Produto> Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }

        public void Adiciona()
        {
            produto = new Produto();

            try
            {
                ObterDados(produto);
                produtos.Add(produto);
                Console.WriteLine("Produto foi adicionado!");
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÃO: {0}", e.Message);
            }
        }

        public void ObterDados(Produto produto)
        {
            try
            {
                Console.Write("Informe a 'CATEGORIA' do produto: ");
                produto.Categoria = Console.ReadLine();
                Console.Write("Informe o 'NOME' do produto: ");
                produto.Nome = Console.ReadLine();
                Console.Write("Informe o 'PESO' do produto: ");
                produto.Peso = double.Parse(Console.ReadLine());
                Console.Write("Informe o 'PREÇO' do produto: ");
                produto.Preco = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: {0}", e.Message);
            }
        }

        public void Listar()
        {
            Console.WriteLine(" ========== LISTA DE PRODUTOS ========== ");
            if (this.produtos.Count == 0)
                Console.WriteLine("ATENÇÃO: Não há produtos adicionados");
            else
            {
                foreach (Produto p in this.produtos)
                {
                    Console.WriteLine("Código: {0}", produto.Codigo);
                    Console.WriteLine("Produto: {0}", produto.Nome);
                    Console.WriteLine("Categoria: {0}", produto.Categoria);
                    Console.WriteLine("Peso: {0}", produto.Peso);
                    Console.WriteLine("Preço: {0}", produto.Preco);
                    Console.WriteLine("- - - - - - - - - - -\n");
                }
            }
        }

        public int Pesquisa(int codigo)
        {
            int posicao = -1;

            foreach (Produto produto in this.produtos)
            {
                if (produto.Codigo == codigo)
                    posicao = this.produtos.IndexOf(produto);
            }

            return posicao;
        }

        public void Remove()
        {
            try
            {
                Console.Write("Informe o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                int posicao = Pesquisa(codigo);

                if (posicao == -1)
                    Console.WriteLine("Cliente não cadastrado! Verifique o código informado!");
                else
                {
                    produtos.Remove(this.produtos[codigo]);
                    Console.WriteLine("Produto removido com sucesso!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
        }

        public void Edita()
        {
            try
            {
                Console.Write("Informe o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                int posicao = Pesquisa(codigo);

                if (posicao == -1)
                    Console.WriteLine("Cliente não cadastrado! Verifique o código informado.");
                else
                {
                    ObterDados(this.produtos[posicao]);
                    Console.WriteLine("Informações atualizadas com sucesso!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
        }
    }
}