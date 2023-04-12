
using Estudos.Locadoras.Dominio.Carros;
using Estudos.Locadoras.Dominio.Enuns;
using Estudos.Locadoras.Dominio.Fabricantes;

namespace Estudos.Locadoras.Tests.Dominios.Entidades
{
    
    public class VeiculoTestes
    {
        [Fact]
        public void DeveCriarVeiculoValido()
        {
            var fabricante = new Fabricante(nome:"Nissan", paisOrigem:"Japão");

            var veiculo = new Veiculo(nome: "Kicks", chassi: "GSYGYSGY4262", fabricante: fabricante, modelo: "SL Xtronic", anoFabricacao: "2018", cor: "Branco", categoria: Categoria.SUVCompacto, descricao: "SUV");

            Assert.NotNull(veiculo);

            Assert.True(veiculo.Nome.Equals("Kicks"));

            Assert.True(veiculo.Categoria == Categoria.SUVCompacto);
        }

        [Fact]
        public void DeveretornarErroQuandoNomeInvalido()
        {
            var fabricante = new Fabricante(nome: "Nissan", paisOrigem: "Japão");         

            var retorno = Assert.Throws<ArgumentException>(() => new Veiculo(nome: "", chassi: "GSYGYSGY4262", fabricante: fabricante, modelo: "SL Xtronic", anoFabricacao: "2018", cor: "Branco", categoria: Categoria.SUVCompacto, descricao: "SUV"));

            Assert.Equal("Nome Obrigatório", retorno.Message);
        }

        [Fact]
        public void DeveretornarErroQuandoChassiInvalido()
        {
            var fabricante = new Fabricante(nome: "Nissan", paisOrigem: "Japão");

            var retorno = Assert.Throws<ArgumentException>(() => new Veiculo(nome: "Kicks", chassi: "", fabricante: fabricante, modelo: "SL Xtronic", anoFabricacao: "2018", cor: "Branco", categoria: Categoria.SUVCompacto, descricao: "SUV"));

            Assert.Equal("Chassi Obrigatório", retorno.Message);
        }

        [Fact]
        public void DeveretornarErroQuandoFabricanteInvalido()
        {
            var retorno = Assert.Throws<ArgumentException>(() => new Veiculo(nome: "Kicks", chassi: "GSYGYSGY4262", fabricante: null, modelo: "SL Xtronic", anoFabricacao: "2018", cor: "Branco", categoria: Categoria.SUVCompacto, descricao: "SUV"));

            Assert.Equal("Fabricante Obrigatório", retorno.Message);
        }
    }
}
