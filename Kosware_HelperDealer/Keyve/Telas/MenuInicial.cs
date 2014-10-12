using System;

namespace Keyve.Telas
{
    public class MenuInicial
    {
        public static void MenuIni()
        {
            ConsoleKey opcao = ConsoleKey.A;
            do
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|             M E N U             |");
                Console.WriteLine("|          I N I C I A L          |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|         1. Vendedor             |");
                Console.WriteLine("|         2. Cliente              |");
                Console.WriteLine("|         3. Produto              |");
                Console.WriteLine("|         4. Pedido               |");
                Console.WriteLine("|         5. Agenda               |");
                Console.WriteLine("|        ESC. Sair                |");
                Console.WriteLine("___________________________________");
                opcao = Console.ReadKey().Key;
                Console.Clear();
                switch (opcao)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine("Vendedor");
                        break;

                    case ConsoleKey.F2:
                        Console.WriteLine("Cliente");
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        MenuProduto menuProduto = new MenuProduto();
                        menuProduto.Produto();
                        break;

                    case ConsoleKey.F4:
                        Console.WriteLine("Pedido");
                        break;

                    case ConsoleKey.F5:
                        Console.WriteLine("Agenda");
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Finalizando Aplicacao");
                        break;
                }
            } while (opcao != ConsoleKey.Escape);
        }

        public static void Main(string[] args)
        {
            Console.Clear();
            MenuIni();
        }
    }
}