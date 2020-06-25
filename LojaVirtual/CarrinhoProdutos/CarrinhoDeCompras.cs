using System;
using System.Collections.Generic;
using LojaVirtual.Produtos;
using System.Text;

namespace LojaVirtual.CarrinhoProdutos
{
    class CarrinhoDeCompras
    {
        internal double ValorTotalCarrinho { get; set; }
        internal List<Produto> ListaProdutos { get; set; }
        internal Produto Produto { get; set; }
        internal int QuantidadeProduto { get; set; }
        internal CarrinhoDeCompras() { }

        internal CarrinhoDeCompras(Produto produto)
        {
            Produto = produto;
        }

        internal void GetProduto()
        {

        }


        internal void RemoveProduto(string nomeProduto)
        {
            
        }


    }
}
