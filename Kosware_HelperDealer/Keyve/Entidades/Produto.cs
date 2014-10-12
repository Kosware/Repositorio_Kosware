using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyve.Entidades
{
    class Produto
    {
        public static int contador = 1;

        public string Categoria { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
            this.Codigo = contador;
            contador++;
        }
    }
}
