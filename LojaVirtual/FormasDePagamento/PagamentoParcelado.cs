using System;

namespace LojaVirtual.FormasDePagamento
{
    class PagamentoParcelado
    {
        internal Pagamento Pagamento { get; set; }
        internal int NumeroDeParcelas { get; set; }
        internal double ValorParcela { get; private set; }
        internal const double Juros = 0.20;

        internal PagamentoParcelado() { }
        internal PagamentoParcelado(Pagamento pagamento, int parcelas)
        {
            Pagamento = pagamento;
            NumeroDeParcelas = parcelas;
            GetOpcoesDeParcelamento();
        }

        private void GetOpcoesDeParcelamento()
        {
            GetValorDasParcelas();
            ExibirValores();
        }

        private void GetValorDasParcelas()
        {
            if (NumeroDeParcelas > 10 || NumeroDeParcelas >= 25 )
            {
                SetValorDaParcelaComJuros();
            }
            else
            {
                SetValorDaParcelaSemJuros();
            }
        }

        private void SetValorDaParcelaSemJuros()
        {
            SetQuantidadeParcelas();
            ValorParcela = Pagamento.ValorTotal / NumeroDeParcelas;
        }

        private void SetValorDaParcelaComJuros()
        {
            SetQuantidadeParcelas();
            AplicarJurosNoValorTotal();
            ValorParcela = Pagamento.ValorTotal / NumeroDeParcelas;
        }

        private int SetQuantidadeParcelas()
        {
            if (NumeroDeParcelas > 25)
            {
                NumeroDeParcelas = 25;
            }
            else if (NumeroDeParcelas <= 0)
            {
                NumeroDeParcelas = 1;
            }
            return NumeroDeParcelas;
        }

        private double GetValorJuros(double valorDesconto) => Pagamento.ValorCarrinho * valorDesconto;
        private void AplicarJurosNoValorTotal() => Pagamento.ValorTotal += GetValorJuros(Juros);
        private void ExibirValores() => Console.WriteLine($"\nValor Total R${Pagamento.ValorTotal:F2}\nParcelado em {NumeroDeParcelas}x R${ValorParcela:F2}");
    }
}
