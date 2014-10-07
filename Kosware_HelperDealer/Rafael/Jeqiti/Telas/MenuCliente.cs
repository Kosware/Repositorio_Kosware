using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AprendendoProgram.Jeqiti.Controle;
namespace AprendendoProgram.Jeqiti.Telas
{
    class MenuCliente : MenuInicial
    {
        ControlaCliente controleCliente = new ControlaCliente();

        public void TelaCliente()
        {
            ConsoleKey opcao = ConsoleKey.A;
            do
            {
                Console.Clear();
                Console.WriteLine("____________________________________");
                Console.WriteLine("|                                  |");
                Console.WriteLine("|             M E N U              |");
                Console.WriteLine("|          C L I E N T E           |");
                Console.WriteLine("|                                  |");
                Console.WriteLine("|        F1. Cadastra Cliente      |");
                Console.WriteLine("|        F2. Lista Cliente         |");
                Console.WriteLine("|        F3. Remove Cliente        |");
                Console.WriteLine("|        F4. Altera Cliente        |");
                Console.WriteLine("|        F5. Ajuda                 |");
                Console.WriteLine("|        F6. Retornar              |");
                Console.WriteLine("____________________________________");
                opcao = Console.ReadKey().Key;
                switch (opcao)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        controleCliente.AdicionaClientes();
                        break;
                    case ConsoleKey.F2:
                        Console.Clear();
                        controleCliente.ListaClientes();
                        break;
                    case ConsoleKey.F3:
                        Console.Clear();
                        controleCliente.RemoveClientes();
                        break;
                    case ConsoleKey.F4:
                        Console.Clear();
                        controleCliente.AlteraClientes();
                        break;
                    case ConsoleKey.F5:

                        break;
                    case ConsoleKey.F6:
                        MenuIni();
                        break;
                }
            } while (opcao != ConsoleKey.F3);
        }
    }
}
