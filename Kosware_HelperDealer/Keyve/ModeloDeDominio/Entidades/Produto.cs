using System;

namespace Keyve.ModeloDeDominio.Entidades
{
    public class Produto
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

        public override string ToString()
        {
            return String.Format("Código: {0}\nCategoria: {1}\nNome: {2}\nPeso: {3}\nPreço: {4:F2}",
                this.Codigo, this.Categoria, this.Nome, this.Peso, this.Preco);
        }

        public override bool Equals(object obj)
        {
            Produto produtoAuxiliar = obj as Produto;
            if (produtoAuxiliar == null)
            {
                return false;
            }
            if (produtoAuxiliar.Codigo == this.Codigo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}