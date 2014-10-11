using Keyve.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyve.Tela
{
    public class MenuProduto : MenuInicial
    {
        public void Produto()
        {
            ControladorProduto controladorProduto = new ControladorProduto();
            ConsoleKey opcao = ConsoleKey.A;
            do
            {
                Console.Clear();
                Console.WriteLine("____________________________________");
                Console.WriteLine("|                                  |");
                Console.WriteLine("|             M E N U              |");
                Console.WriteLine("|          P R O D U T O           |");
                Console.WriteLine("|                                  |");
                Console.WriteLine("|        1. Cadastra Produtos      |");
                Console.WriteLine("|        2. Lista Produtos         |");
                Console.WriteLine("|        3. Remove Produtos        |");
                Console.WriteLine("|        4. Altera Produtos        |");
                Console.WriteLine("|        5. Ajuda                  |");
                Console.WriteLine("|        ESC. Retornar             |");
                Console.WriteLine("____________________________________");
                opcao = Console.ReadKey().Key;
                Console.Clear();
                switch (opcao)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        controladorProduto.Cadastrar();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        //Console.WriteLine("Finalizando Aplicacao");
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        MenuIni();
                        break;
                }
            } while (opcao != ConsoleKey.Escape);
        }
    }
}
