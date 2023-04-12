
namespace Estudos.Locadoras.Dominio.Fabricantes
{
    public class Fabricante
    {
        //Criar o Contrutor
        public Fabricante(string nome, string paisOrigem)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            PaisOrigem = paisOrigem;

            Validar();
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string PaisOrigem { get; private set; }

        public Fabricante AlterarNome(string nome)
        {
            Nome = nome;
            Validar();

            return this;
        }


        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new ArgumentException("Nome inválido");
        }
    }
}
