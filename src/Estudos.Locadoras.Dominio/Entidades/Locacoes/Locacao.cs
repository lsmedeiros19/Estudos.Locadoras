

using Estudos.Locadoras.Dominio.Carros;
using Estudos.Locadoras.Dominio.Entidades.Clientes;
using Estudos.Locadoras.Dominio.Enuns;

namespace Estudos.Locadoras.Dominio.Entidades.Locacoes
{
    public class Locacao
    {
        public Locacao(Cliente cliente, Veiculo veiculo, DateTime dataInicio, DateTime dataFim, FormasPagamento formasPagamento, decimal valorTotal)
        {
            Cliente = cliente;
            Veiculo = veiculo;
            DataInicio = dataInicio;
            DataFim = dataFim;
            FormasPagamento = formasPagamento;
            ValorTotal = valorTotal;

            Validar();
            CalcularValorLocacao();
        }

        public Guid Id { get; private set; }

        public Cliente Cliente { get; private set; }

        public Veiculo Veiculo { get; private set; }

        public DateTime DataInicio { get; private set; }

        public DateTime DataFim { get; private set; }

        public FormasPagamento FormasPagamento { get; private set; }

        public StatusLocacao StatusLocacao { get; private set; }

        public decimal ValorTotal { get; private set; }
         

        private void CalcularValorLocacao()
        {
            ValorTotal = Veiculo.ValorDiaria * (DataInicio - DataFim).Days;
        }

        public void AlterarPeriodoLocacao(DateTime dataInicio, DateTime dataFim)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;

            CalcularValorLocacao();
        }

        public void AlterarStatus(StatusLocacao statusLocacao)
        {
            StatusLocacao = statusLocacao;
        }

        public void Validar()
        {
            if (Cliente is null)
                throw new ArgumentException("Cliente Obrigatório");

            if (Veiculo is null)
                throw new ArgumentException("Veiculo Obrigatório");

        }
    }
    }
}
