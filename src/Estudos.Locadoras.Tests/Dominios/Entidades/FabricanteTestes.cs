

using Estudos.Locadoras.Dominio.Fabricantes;

namespace Estudos.Locadoras.Tests.Dominios.Entidades
{

    public class FabricanteTestes
    {
        [Fact]
        public void DeveRetornarFabricanteValido()
        {
            var fabricante = new Fabricante(nome: "Nissan", paisOrigem: "Japão");

            Assert.NotNull(fabricante);

            Assert.True(fabricante.Nome == "Nissan");
        }

        [Fact]
        public void DeveAlterarNomeDoFrabrticante()
        {
            var fabricante = new Fabricante(nome: "Nissan", paisOrigem: "Japão");

            Assert.NotNull(fabricante);

            fabricante.AlterarNome("Toyota");

            Assert.True(fabricante.Nome == "Toyota");
        }

        [Fact]
        public void DeveRetornarErroComNomeInvalido()
        {
            var retorno = Assert.Throws<ArgumentException>(() => new Fabricante(nome: "", paisOrigem: "Japão"));

            Assert.Equal("Nome inválido", retorno.Message);
        }
    }
}
