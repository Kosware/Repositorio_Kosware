using Keyve.ModeloDeDominio.Entidades;
using System;
using System.Collections.Generic;

namespace Keyve.ModeloDeDominio.Controladores
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
            produto = new Produto();
            DefinirInformacoes(produto);
            produtos.Add(produto);
        }

        public void DefinirInformacoes(Produto produto)
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
                Console.WriteLine("ERRO: " + e.Message);
            }
        }

        public void Listar()
        {
            Console.WriteLine(" ========== LISTA DE PRODUTOS ========== ");
            foreach (Produto produto in produtos)
            {
                if (produto != null)
                {
                    Console.WriteLine(produto.ToString());
                    Console.WriteLine("---------------------------------------\n");
                }
            }
        }

        public Produto Buscar(int codigo)
        {
            foreach (Produto produto in produtos)
            {
                if (produto.Codigo == codigo)
                {
                    return produto;
                }
            }
            return null;
        }

        public void Remove()
        {
            try
            {
                Console.Write("Informe o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                Produto auxiliar = Buscar(codigo);
                if (auxiliar == null)
                {
                    Console.WriteLine("Cliente não cadastrado! Verifique o código informado.");
                }
                else
                {
                    produtos.Remove(auxiliar);
                    Console.WriteLine("Produto removido com sucesso!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
        }

        public void Alterar()
        {
            try
            {
                Console.Write("Informe o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                Produto auxiliar = Buscar(codigo);
                if (auxiliar == null)
                {
                    Console.WriteLine("Cliente não cadastrado! Verifique o código informado.");
                }
                else
                {
                    DefinirInformacoes(auxiliar);
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