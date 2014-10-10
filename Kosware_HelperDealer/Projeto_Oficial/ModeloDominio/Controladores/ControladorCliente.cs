using Kosware_Helper_Dealer.Entidades;
using System;
using System.Collections.Generic;

namespace Projeto_Oficial.ModeloDominio.Controladores
{
    internal class ControladorCliente
    {
        private Cliente cliente;
        private List<Cliente> clientes = new List<Cliente>();

        internal List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        public void Adiciona()
        {
            this.cliente = new Cliente();

            try
            {
                ObterDados(cliente);
                this.clientes.Add(cliente);
                Console.WriteLine("Cliente {0} foi adicionado!", this.cliente.Nome);
            }
            catch (Exception e)
            {
                Console.WriteLine("Atenção: {0}!", e.Message);
            }
        }

        public void Edita()
        {
            try
            {
                Console.Write("Informe o código do cliente: ");
                int codigo = int.Parse(Console.ReadLine());

                int posicaoCliente = Pesquisa(codigo);

                if (posicaoCliente == -1)
                    Console.WriteLine("ATENÇÃO: Cliente não cadastrado! Informe código válido!");
                else
                {
                    ObterDados(this.clientes[posicaoCliente]);
                    Console.WriteLine("Dados foram atualizados com sucesso!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÃO: {0}", e.Message);
            }
        }

        public void Remove()
        {
            try
            {
                Console.Write("Informe o código do cliente: ");
                int codigo = int.Parse(Console.ReadLine());

                int posicaoCliente = Pesquisa(codigo);

                if (posicaoCliente == -1)
                    Console.WriteLine("ATENÇÃO: Cliente não cadastrado! Informe código válido!");
                else
                {
                    this.clientes.RemoveAt(posicaoCliente);
                    Console.WriteLine("Cliente foi removido do sistema com sucesso!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÃO: {0}", e.Message);
            }
        }

        public void ObterDados(Cliente cliente)
        {
            try
            {
                Console.Write("Informe o 'NOME' do cliente: ");
                cliente.Nome = Console.ReadLine();
                Console.Write("Informe o 'CPF' do cliente: ");
                cliente.Cpf = Console.ReadLine();
                Console.Write("Informe o 'ENDEREÇO' do cliente: ");
                cliente.Endereco = Console.ReadLine();
                Console.WriteLine("Informe o 'TELEFONE' do cliente: ");
                cliente.Telefone = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Atenção: {0}!", e.Message);
            }
        }

        public int Pesquisa(int codigo)
        {
            int posicao = -1;

            for (int i = 0; i < this.clientes.Count; i++)
            {
                if (codigo == clientes[i].Codigo)
                {
                    posicao = i;
                    break;
                }
            }

            return posicao;
        }
    }
}