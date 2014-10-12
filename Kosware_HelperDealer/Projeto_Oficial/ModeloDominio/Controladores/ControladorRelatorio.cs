using Kosware_Helper_Dealer.Entidades;
using System;
using System.IO;

namespace Projeto_Oficial.ModeloDominio.Controladores
{
    internal class ControladorRelatorio
    {
        private ControladorCliente controladorCliente;
        private ControladorPedido controladorPedido;
        private ControladorProduto controladorProduto;
        private ControladorVendedor controladorVendedor;

        public ControladorRelatorio(ControladorCliente controleCliente, ControladorPedido controlePedido, ControladorProduto controleProduto, ControladorVendedor controleVendedor)
        {
            this.controladorCliente = controleCliente;
            this.controladorPedido = controlePedido;
            this.controladorProduto = controleProduto;
            this.controladorVendedor = controleVendedor;
        }

        public void GerarRelatorio()
        {
            DateTime dataInicio, dataTermino;
            double totalVendido = 0;

            try
            {
                Console.WriteLine("Informe a data de inicio: ");
                dataInicio = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Informe a data de termino: ");
                dataTermino = DateTime.Parse(Console.ReadLine());

                string folder = @"C:\Kosware_HelperDealer";
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                TextWriter escritor = new StreamWriter(@"C:\Kosware_HelperDealer\Relatorio_Kosware.txt");

                escritor.WriteLine("          PEDIDO");
                escritor.WriteLine(" ");

                foreach (Pedido pedido in controladorPedido.Pedidos)
                {
                    if (dataInicio >= pedido.DataPedido && dataTermino <= pedido.DataPedido)
                    {
                        escritor.WriteLine("Código: {0}", pedido.Codigo);
                        escritor.WriteLine("Data do pedido: {0}", pedido.DataPedido.ToLongDateString());
                        escritor.WriteLine("Data prevista da entrega: {0}", pedido.DataEntrega.ToLongDateString());
                        escritor.WriteLine("Cliente: {0}", this.controladorCliente.Clientes[pedido.IdCliente].Nome);
                        escritor.WriteLine("Vendedor: {0}", this.controladorVendedor.Vendedores[pedido.IdVendedor].Nome);
                        escritor.WriteLine("Produto: {0}", this.controladorProduto.Produtos[pedido.IdProduto].Nome);
                        escritor.WriteLine("Quantidade do produto: {0}", pedido.Quantidade);
                        escritor.WriteLine("Total: R$ {0:F2}", pedido.Total);
                        escritor.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                        totalVendido += pedido.Total;
                    }
                }

                escritor.WriteLine("Valor Total de Vendas: R$ {0:F2}", totalVendido);
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÃO: {0}", e.Message);
                return;
            }
        }
    }
}