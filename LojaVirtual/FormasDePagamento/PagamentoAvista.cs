using System;

namespace LojaVirtual.FormasDePagamento
{
    class PagamentoAvista 
    {
        internal Pagamento Pagamento { get; set; }
        internal const double DescontoAvista = 0.10;

        internal PagamentoAvista() { }
        internal PagamentoAvista(Pagamento pagamento)
        {
            Pagamento = pagamento;
            AplicarDesconto();
        }

        private void AplicarDesconto()
        {
            AplicarDescontoNoValorTotal();
            ExibirValorComDesconto();
        }

        private double GetDesconto(double valorDesconto) =>  Pagamento.ValorCarrinho * valorDesconto;

        private void AplicarDescontoNoValorTotal() => Pagamento.ValorTotal -= GetDesconto(DescontoAvista);

        private void ExibirValorComDesconto() => Console.WriteLine($"\nValor Total a vista R${Pagamento.ValorTotal:F2}");
    }
}
