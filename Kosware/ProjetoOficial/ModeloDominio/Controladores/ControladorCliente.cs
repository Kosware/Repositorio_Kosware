using Kosware_Helper_Dealer.Entidades;
using System;
using System.Collections.Generic;

namespace ProjetoOficial.ModeloDominio.Controladores
{
    class ControladorCliente
    {
        private Cliente cliente;
        private List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        public void ObterDados(Cliente cliente)
        {
            try
            {
                Console.WriteLine("Informe o nome do cliente: ");
                cliente.Nome = Console.ReadLine();
                Console.WriteLine("Informe o CPF do cliente ");
                cliente.Cpf = Console.ReadLine();
                Console.WriteLine("Informe o endereço do cliente: ");
                cliente.Endereco = Console.ReadLine();
                Console.WriteLine("Informe o telefone do cliente: ");
                cliente.Telefone = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÂO: {0}", e.Message);
            }
        }

        public void Adiciona()
        {
            cliente = new Cliente();

            try
            {
                ObterDados(cliente);
                clientes.Add(cliente);
            }
            catch (Exception e)
            {
                Console.WriteLine("Atenção: {0}", e.Message);
            }
        }

        public void Remove()
        {
            try
            {
                Console.Write("Informe o código do cliente: ");
                int codigo = int.Parse(Console.ReadLine());

                int posicao = Pesquisa(codigo);

                if (posicao != 1)
                {
                    this.clientes.Remove(clientes[posicao]);
                    Console.WriteLine("Cliente foi removido!");
                }
                else
                    Console.WriteLine("Não foi possível remover cliente!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Atenção: {0}", e.Message);
            }
        }

        public int Pesquisa(int codigo)
        {
            int posicao = -1;

            foreach (Cliente cliente in this.clientes)
            {
                if (cliente.Codigo == codigo)
                    posicao = clientes.IndexOf(cliente);
            }

            return posicao;
        }

        public void Lista()
        {
            if (this.clientes.Count == 0)
                Console.WriteLine("ATENÇÃO: Não há clientes cadastrados!");
            else
            {
                foreach (Cliente cliente in this.clientes)
                {
                    Console.WriteLine("Código: {0}", cliente.Codigo);
                    Console.WriteLine("Cliente: {0}", cliente.Nome);
                    Console.WriteLine("Endereço: {0}", cliente.Endereco);
                    Console.WriteLine("Telefone: {0}", cliente.Telefone);
                    Console.WriteLine("CPF: {0}", cliente.Cpf);
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
                ObterDados(this.clientes[posicao]);
                Console.WriteLine("Dados do cliente foram atualizados!");
            }
            else
                Console.WriteLine("Não foi possível atualizar dados do cliente!");
        }
    }
}