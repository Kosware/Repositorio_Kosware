using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosware_Helper_Dealer.Entidades
{
    class Cliente : Pessoa
    {
        public static int contador = 1;

        public Cliente()
        {
            this.Codigo = contador;
            contador++;
        }
    }
}
