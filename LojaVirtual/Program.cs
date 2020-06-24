using LojaVirtual.FormasDePagamento;
using LojaVirtual.CarrinhoProdutos;
using System;
using LojaVirtual.Produtos;

namespace LojaVirtual
{
    class Program
    {

        static void Main(string[] args)
        {
            //OpcaoPagamento(1000);
            AddProdutoNoCarrinho();
        }

        static void AddProdutoNoCarrinho()
        {
            var produto = new Produto("iPhone 11",1000 );
            //produto = new Produto("TV50",1000);
        }

        
        static void OpcaoPagamento(double valor) // teste classes Pagamento/Avista/Parcelado 
        {
            var valorCompra = new Pagamento(valor);
            
            valorCompra.ExibirOpcoesPagmento();
            byte opcao = byte.Parse(Console.ReadLine());
            if (opcao <= 1)
            {
                var desconto = new PagamentoAvista(valorCompra);
            }
            else if (opcao >= 2)
            {
                valorCompra.GetNumeroDeParcelas();
                int numeroParcelas = int.Parse(Console.ReadLine());
                var dividirPagamento = new PagamentoParcelado(valorCompra, numeroParcelas);
            }  
        }   
    }
}
