using Kosware_Helper_Dealer.Entidades;
using System;
using System.Collections.Generic;

namespace ProjetoOficial.ModeloDominio.Controladores
{
    class ControladorVendedor
    {
        private Vendedor vendedor;
        private List<Vendedor> vendedores = new List<Vendedor>();

        public List<Vendedor> Vendedores
        {
            get { return this.vendedores; }
            set { this.vendedores = value; }
        }

        public void ObterDados(Vendedor vendedor)
        {
            try
            {
                Console.WriteLine("Informe o nome do vendedor: ");
                vendedor.Nome = Console.ReadLine();
                Console.WriteLine("Informe o CPF do vendedor ");
                vendedor.Cpf = Console.ReadLine();
                Console.WriteLine("Informe o endereço do vendedor: ");
                vendedor.Endereco = Console.ReadLine();
                Console.WriteLine("Informe o telefone do vendedor: ");
                vendedor.Telefone = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Atenção: {0}", e.Message);
            }
        }

        public void Adiciona()
        {
            vendedor = new Vendedor();

            try
            {
                ObterDados(vendedor);
                vendedores.Add(vendedor);
                Console.WriteLine("Vendedor foi adicionado!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Atenção: {0}", e.Message);
            }
        }

        public int Pesquisa(int codigo)
        {
            int posicao = -1;

            foreach (Vendedor vendedor in this.vendedores)
            {
                if (vendedor.Codigo == codigo)
                    posicao = this.vendedores.IndexOf(vendedor);
            }

            return posicao;
        }

        public void RemoveVendedor()
        {
            try
            {
                Console.Write("Informe o código do vendedor: ");
                int codigo = int.Parse(Console.ReadLine());

                int posicao = Pesquisa(codigo);

                if (posicao != 1)
                {
                    this.vendedores.Remove(vendedores[posicao]);
                    Console.WriteLine("Vendedor foi removido!");
                }
                else
                    Console.WriteLine("Não foi possível remover vendedor!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Atenção: {0}", e.Message);
            }
        }

        public void Lista()
        {
            if (this.vendedores.Count == 0)
                Console.WriteLine("ATENÇÃO: Não há vendedores cadastrados!");
            else
            {
                foreach (Vendedor vendedor in this.vendedores)
                {
                    Console.WriteLine("Código: {0}", vendedor.Codigo);
                    Console.WriteLine("Cliente: {0}", vendedor.Nome);
                    Console.WriteLine("Endereço: {0}", vendedor.Endereco);
                    Console.WriteLine("Telefone: {0}", vendedor.Telefone);
                    Console.WriteLine("CPF: {0}", vendedor.Cpf);
                    Console.WriteLine("- - - - - - - - - - - - - - - \n");
                }
            }
        }

        public void Edita()
        {
            Console.Write("Informe o código do cliente: ");
            int codigo = int.Parse(Console.ReadLine());

            int posicao = Pesquisa(codigo);

            if (posicao != -1)
            {
                ObterDados(this.vendedores[posicao]);
                Console.WriteLine("Dados do vendedor foram atualizados!");
            }
            else
                Console.WriteLine("Não foi possível atualizar dados do vendedor!");
        }
    }
}