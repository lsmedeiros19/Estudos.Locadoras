using Estudos.Locadoras.Dominio.Enuns;
using Estudos.Locadoras.Dominio.Fabricantes;

namespace Estudos.Locadoras.Dominio.Carros
{
    public class Veiculo
    {
        public Veiculo(string nome, string chassi, Fabricante fabricante, string modelo, string anoFabricacao, string cor, Categoria categoria, string descricao, decimal valorDiaria)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Chassi = chassi;
            Fabricante = fabricante;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            Cor = cor;
            Categoria = categoria;
            Descricao = descricao;
            ValorDiaria = valorDiaria;

            Validar();
        }

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public string Chassi { get; private set; }

        public Fabricante Fabricante { get; private set; }

        public string Modelo { get; private set; }

        public string AnoFabricacao { get; private set; }

        public string Cor { get; private set; }

        public Categoria Categoria { get; private set; }

        public string Descricao { get; private set; }

        public decimal ValorDiaria { get; private set; }

        public Veiculo AlterarNome(string nome)
        {
            Nome = nome;
            Validar();
            return this;
        }

        public Fabricante AlterarFabricante(Fabricante fabricante)
        {
            Fabricante = fabricante;
            Validar();
            return fabricante;
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new ArgumentException("Nome Obrigatório");

            if (string.IsNullOrEmpty(Chassi))
                throw new ArgumentException("Chassi Obrigatório");

            if (Fabricante == null)
                throw new ArgumentException("Fabricante Obrigatório");
        }
    }
}
