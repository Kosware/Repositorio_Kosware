using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AprendendoProgram.Jeqiti.Interfaces;
using System.Collections;
using AprendendoProgram.Jeqiti.Dominios;
namespace AprendendoProgram.Jeqiti.Controle
{
    public class ControlaCliente : ICliente
    {
        Cliente cliente = new Cliente();
        List<Cliente> ListaCliente = new List<Cliente>();
        public void AdicionaClientes()
        {
            try
            {
                Console.WriteLine("Informe o Nome do cliente: ");
                cliente.Nome = Console.ReadLine();
                Console.WriteLine("Informe o codigo do cliente: ");
                cliente.Codigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o cpf do cliente ");
                cliente.Cpf = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe o endereco do cliente: ");
                cliente.Endereco = Console.ReadLine();
                Console.WriteLine("Informe o telefone do clinte: ");
                cliente.Telefone = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Dado inserido invalido, por favor insira dados validos!");
                AdicionaClientes();
            }
            ListaCliente.Add(cliente);
        }

        public void RemoveClientes()
        {
            Console.WriteLine("Informe o cliente a remover: ");
            string RemoveClientes = Console.ReadLine();
            foreach (var list in ListaCliente)
            {
                if (list.Nome == RemoveClientes)
                {
                    ListaCliente.Remove(list);
                }
            }
        }
        public void ListaClientes()
        {
            foreach (var lista in ListaCliente)
            {
                Console.WriteLine("Nome do cliente: " + lista.Nome);
                Console.WriteLine("Codigo do cliente: " + lista.Codigo);
                Console.WriteLine("Informe o cpf do cliente: " + lista.Cpf);
                Console.WriteLine("Informe o endereco do cliente: " + lista.Endereco);
                Console.WriteLine("Informe o telefone do cliente: " + lista.Telefone);
                Console.WriteLine();
            }
        }
        public void AlteraClientes()
        {
            Console.WriteLine("Informe o nome da pessoa a alterar: ");
            string pessoaAlterar = Console.ReadLine();
            foreach (var Encontrar in ListaCliente)
            {
                if (Encontrar.Nome == pessoaAlterar)
                {
                    Console.WriteLine("Informe o Nome do cliente: ");
                    cliente.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o codigo do cliente: ");
                    cliente.Codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o cpf do cliente ");
                    cliente.Cpf = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o endereco do cliente: ");
                    cliente.Endereco = Console.ReadLine();
                    Console.WriteLine("Informe o telefone do clinte: ");
                    cliente.Telefone = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
    }
}
