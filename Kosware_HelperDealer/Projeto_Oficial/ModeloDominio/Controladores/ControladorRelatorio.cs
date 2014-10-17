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

        public void GerarRelatorioPorData()
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

                escritor.WriteLine("          PEDIDOS");
                escritor.WriteLine("Data de Inicio: {0}", dataInicio.ToLongDateString());
                escritor.WriteLine("Data de Termino: {0}", dataTermino.ToLongDateString());

                Console.WriteLine("Lista de Pedidos: ");

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
                double comissao = CalcularComissao(totalVendido);
                escritor.WriteLine("Comissão do Vendedor: R$ {0:F2}", comissao);
                escritor.WriteLine("Comissão da Empresa:R$ {0:F2}", totalVendido - comissao);
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÃO: {0}", e.Message);
                return;
            }
        }

        public void GerarRelatorioPorCliente()
        {
            double totalVendido = 0;

            try
            {
                Console.Write("Informe o código do cliente: ");
                int codigoCliente = int.Parse(Console.ReadLine());

                if (this.controladorCliente.Pesquisa(codigoCliente) == -1)
                    Console.WriteLine("ATENÇÃO: Cliente não foi encontrado! Verifique código informado!");
                else
                {
                    string folder = @"C:\Kosware_HelperDealer";
                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);
                    TextWriter escritor = new StreamWriter(@"C:\Kosware_HelperDealer\Relatorio_Kosware.txt");
                    escritor.WriteLine("          PEDIDOS");
                    escritor.WriteLine("Pedidos do Cliente: {0}", this.controladorCliente.Clientes[codigoCliente].Nome);

                    escritor.WriteLine("Lista de Pedidos: ");

                    foreach (Pedido pedido in controladorPedido.Pedidos)
                    {
                        if (pedido.IdCliente == codigoCliente)
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
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÃO: {0}", e.Message);
                return;
            }
        }

        public void GerarRelatorioPorVendedor()
        {
            double totalVendido = 0;

            try
            {
                Console.Write("Informe o código do vendedor: ");
                int codigoVendedor = int.Parse(Console.ReadLine());

                if (this.controladorVendedor.Pesquisa(codigoVendedor) == -1)
                    Console.WriteLine("ATENÇÃO: Cliente não foi encontrado! Verifique código informado!");
                else
                {
                    string folder = @"C:\Kosware_HelperDealer";
                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);
                    TextWriter escritor = new StreamWriter(@"C:\Kosware_HelperDealer\Relatorio_Kosware.txt");
                    escritor.WriteLine("          PEDIDOS");
                    escritor.WriteLine("Pedidos do Vendedor: {0}", this.controladorVendedor.Vendedores[codigoVendedor].Nome);

                    escritor.WriteLine("Lista de Pedidos: ");

                    foreach (Pedido pedido in controladorPedido.Pedidos)
                    {
                        if (pedido.IdVendedor == codigoVendedor)
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
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÃO: {0}", e.Message);
                return;
            }
        }

        public void GerarRelatorioPorProduto()
        {
            double totalVendido = 0;

            try
            {
                Console.Write("Informe o código do vendedor: ");
                int codigoProduto = int.Parse(Console.ReadLine());

                if (this.controladorProduto.Pesquisa(codigoProduto) == -1)
                    Console.WriteLine("ATENÇÃO: Produto não foi encontrado! Verifique código informado!");
                else
                {
                    string folder = @"C:\Kosware_HelperDealer";
                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);
                    TextWriter escritor = new StreamWriter(@"C:\Kosware_HelperDealer\Relatorio_Kosware.txt");
                    escritor.WriteLine("          PEDIDOS");
                    escritor.WriteLine("Pedidos do Produto: {0}", this.controladorProduto.Produtos[codigoProduto].Nome);

                    escritor.WriteLine("Lista de Pedidos: ");

                    foreach (Pedido pedido in controladorPedido.Pedidos)
                    {
                        if (pedido.IdProduto == codigoProduto)
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
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÃO: {0}", e.Message);
                return;
            }
        }

        public double CalcularComissao(double totalVendas)
        {
            Console.Write("Informe a parcela de comissão (%): ");
            int comissao = int.Parse(Console.ReadLine());
            if (comissao >= 0 && comissao <= 100)
                return totalVendas / 100 * comissao;
            else
                throw new ArgumentException("Não foi possível calcular a comissão!");
        }

        public void CalcularComissao()
        {
            DateTime dataInicio, dataTermino;
            double totalVendido = 0;

            try
            {
                Console.WriteLine("Informe a data de inicio: ");
                dataInicio = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Informe a data de termino: ");
                dataTermino = DateTime.Parse(Console.ReadLine());

                foreach (Pedido pedido in controladorPedido.Pedidos)
                {
                    if (dataInicio >= pedido.DataPedido && dataTermino <= pedido.DataPedido)
                        totalVendido += pedido.Total;
                }

                Console.WriteLine("Valor Total de Vendas: R$ {0:F2}", totalVendido);
                double comissao = CalcularComissao(totalVendido);
                Console.WriteLine("Comissão do Vendedor: R$ {0:F2}", comissao);
                Console.WriteLine("Comissão da Empresa: R$ {0:F2}", totalVendido - comissao);
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÃO: {0}", e.Message);
            }
        }

        public void ObterRelatorio()
        {
            try
            {
                TextReader leitor = new StreamReader(@"C:\Kosware_HelperDealer\Relatorio_Kosware.txt");
                string linha = "";
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ATENÇÃO: {0}", e.Message);
            }
        }
    }
}