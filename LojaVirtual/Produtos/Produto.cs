using System;
using System.Collections.Generic;


namespace LojaVirtual.Produtos
{
    class Produto
    {
        internal string NomeProduto { get; set; }
        internal double ValorProduto { get; set; }
        internal List<string> ListaProdutos { get; set; } = new List<string>();
        

        internal Produto() { }

        internal Produto(string nomeProduto, double valorProduto) 
        {
            NomeProduto = nomeProduto;
            ValorProduto = valorProduto;
            GetDadosProduto(nomeProduto, valorProduto);
        }

        internal void GetDadosProduto(string nome, double valor)
        {   
            var DadosProduto = new Dictionary<string, Produto>()
            {
                { nome, new Produto {NomeProduto = nome, ValorProduto = valor}}
            };

            foreach (var prod in DadosProduto)
            {
                Console.WriteLine($"{prod.Key}");
            }

        }

        internal void ExibirDescricaoProduto()
        {
            
            foreach (var prod in ListaProdutos)
            {
                  Console.WriteLine($"{prod}");
            }
        }
    }
}
