using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AprendendoProgram.Jeqiti.Interfaces;
using System.Collections;
namespace AprendendoProgram.Jeqiti.Controle
{
    public class ControlaVendedor : IVendedor
    {
        Vendedor vendedor = new Vendedor();
        List<Vendedor> ListVendedor = new List<Vendedor>();
        public void AdicionaVendedor()
        {
            try
            {
                Console.WriteLine("Informe o Nome do vendedor: ");
                vendedor.Nome = Console.ReadLine();
                Console.WriteLine("Informe o codigo do vendedor: ");
                vendedor.Codigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o cpf do vendedor ");
                vendedor.Cpf = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe o endereco do vendedor: ");
                vendedor.Endereco = Console.ReadLine();
                Console.WriteLine("Informe o telefone do clinte: ");
                vendedor.Telefone = Convert.ToDouble(Console.ReadLine());
        }
            catch (FormatException)
            {
                Console.WriteLine("Dado inserido invalido, por favor insira dados validos!");
                AdicionaVendedor();
            }
            ListVendedor.Add(vendedor);
        }

        public void RemoveVendedor()
        {
            Console.WriteLine("Informe o cliente a remover: ");
            string RemoveVendedores = Console.ReadLine();
            foreach (var list in ListVendedor)
            {
                if (list.Nome == RemoveVendedores)
                {
                    ListVendedor.Remove(list);
        }
            }
        }

        public void ListaVendedor()
        {
            foreach (var lista in ListVendedor)
            {
                Console.WriteLine("Nome do cliente: " + lista.Nome);
                Console.WriteLine("Codigo do cliente: " + lista.Codigo);
                Console.WriteLine("Informe o cpf do cliente: " + lista.Cpf);
                Console.WriteLine("Informe o endereco do cliente: " + lista.Endereco);
                Console.WriteLine("Informe o telefone do cliente: " + lista.Telefone);
                Console.WriteLine();
            }
        }

        public void AlteraVendedor()
        {
            Console.WriteLine("Informe o nome da pessoa a alterar: ");
            string pessoaAlterar = Console.ReadLine();
            foreach (var Encontrar in ListVendedor)
            {
                if (Encontrar.Nome == pessoaAlterar)
                {
                    Console.WriteLine("Informe o Nome do cliente: ");
                    vendedor.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o codigo do cliente: ");
                    vendedor.Codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o cpf do cliente ");
                    vendedor.Cpf = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o endereco do cliente: ");
                    vendedor.Endereco = Console.ReadLine();
                    Console.WriteLine("Informe o telefone do clinte: ");
                    vendedor.Telefone = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
    }
}
