using System;
using System.Collections.Generic;


namespace LojaVirtual.Produtos
{
<<<<<<< HEAD
    abstract class Produto
    {
        internal string ProductName { get; set; }
        internal double ProductValue { get; set; }
        internal string ProductDescrition { get; set; }
        internal List<string> ProductList { get; set; } = new List<string>();
=======
    class Produto
    {
        internal string NomeProduto { get; set; }
        internal double ValorProduto { get; set; }
        internal List<string> ListaProdutos { get; set; } = new List<string>();
>>>>>>> 267041bfa7490c912a56911cc5c69687370788d9
        

        internal Produto() { }

<<<<<<< HEAD
        internal Produto(string name, string descrition, double value) 
        {
            ProductName = name;
            ProductDescrition = descrition;
            ProductValue = value;
        }

        internal void GetProductData(string name, string descrition, double value)
        {
            var productData = new Dictionary<string, string>();
            productData.Add("Name", name);
            productData.Add("Descrition", descrition);
            productData.Add("Value", value.ToString());
=======
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
>>>>>>> 267041bfa7490c912a56911cc5c69687370788d9
        }
    }
}
