using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoProgram.Jeqiti.Telas
{
    class MenuProduto : MenuInicial
    {
        public void Produto()
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
                Console.WriteLine("|        F1. Cadastra Produtos     |");
                Console.WriteLine("|        F2. Lista Produtos        |");
                Console.WriteLine("|        F3. Remove Produtos       |");
                Console.WriteLine("|        F4. Altera Produtos       |");
                Console.WriteLine("|        F5. Ajuda                 |");
                Console.WriteLine("|        F6. Retornar              |");
                Console.WriteLine("____________________________________");
                opcao = Console.ReadKey().Key;
                switch (opcao)
                {
                    case ConsoleKey.F1:
                        break;
                    case ConsoleKey.F2:
                        break;
                    case ConsoleKey.F3:
                        Console.WriteLine("Finalizando Aplicacao");
                        break;
                    case ConsoleKey.F4:
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
