﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosware_Helper_Dealer.Entidades
{
    class Vendedor : Pessoa
    {
        public static int contador = 1;

        public Vendedor()
        {
            this.Codigo = contador;
            contador++;
        }
    }
}
