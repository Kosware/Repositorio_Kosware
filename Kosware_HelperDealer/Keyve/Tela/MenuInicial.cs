using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyve.Tela
{
    public class MenuInicial
    {
        public static void MenuIni()
        {
            ConsoleKey opcao = ConsoleKey.A;
            Console.Clear();
            do
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|             M E N U             |");
                Console.WriteLine("|          I N I C I A L          |");
                Console.WriteLine("|                                 |");
                //Console.WriteLine("|        F1. Vendedor             |");
                //Console.WriteLine("|        F2. Cliente              |");
                Console.WriteLine("|        3. Produto               |");
                //Console.WriteLine("|        F4. Pedido               |");
                //Console.WriteLine("|        F5. Agenda               |");
                Console.WriteLine("|        ESC. Sair                |");
                Console.WriteLine("___________________________________");
                opcao = Console.ReadKey().Key;
                switch (opcao)
                {
                    //case ConsoleKey.F1:
                    //    //MenuVendedor menuVendedor = new MenuVendedor();
                    //    //menuVendedor.TelaVendedor();
                    //    break;
                    //case ConsoleKey.F2:
                    //    //MenuCliente menuCliente = new MenuCliente();
                    //    //menuCliente.TelaCliente();
                    //    break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        MenuProduto menuProduto = new MenuProduto();
                        menuProduto.Produto();
                        break;
                    //case ConsoleKey.F4:
                    //    //MenuPedido menuPedido = new MenuPedido();
                    //    //menuPedido.TelaPedido();
                    //    break;
                    //case ConsoleKey.F5:
                    //    //MenuAgenda menuAgenda = new MenuAgenda();
                    //    //menuAgenda.TelaAgenda();
                    //    break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Finalizando Aplicacao");
                        break;
                }
            } while (opcao != ConsoleKey.Escape);
        }
        public static void Main()
        {
            Console.Clear();
            MenuIni();
        }
    }
}
