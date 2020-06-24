using System;

namespace LojaVirtual.FormasDePagamento
{
    class Pagamento
    {
        internal double ValorCarrinho { get; private set; }
        internal double ValorTotal = 0;

        internal Pagamento() { }
        
        internal Pagamento(double valorCarrinho)
        {
            ValorCarrinho = valorCarrinho;
            Totalizador();
        }

        private void Totalizador()
        {
            ValorTotal += ValorCarrinho;
            ExibirValorTotal();
        }

        internal void ExibirOpcoesPagmento()
        {
            Console.WriteLine($"\nFormas de Pagamento\n    [1] A Vista\n    [2] Parcelamento\nOpções de parcelamento: 10x sem juros ou 25x com juros");
            Console.Write("Opção de pagamento: ");
        }
        internal void GetNumeroDeParcelas() => Console.Write("Quantidade de parcelas: ");
        private void ExibirValorTotal() => Console.WriteLine($"Valor total R${ValorTotal:F2}");
    }
}
