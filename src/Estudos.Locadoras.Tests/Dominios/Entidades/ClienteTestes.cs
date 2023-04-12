using Estudos.Locadoras.Dominio.Entidades.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Locadoras.Tests.Dominios.Entidades
{
    public class ClienteTestes
    {
        [Fact]
        public void DeveRetornarClienteValido()
        {
            //Arrange
            var cliente = new Cliente(nome:"Leandro", cpf:"10125485215", dataNascimento:DateTime.Now, logradouro:"Rua Apia", cep:"21214560", uf:"RJ",
                cidade:"Rio de Janeiro", bairro:"Vila da Penha", numero:65, complemento:"Fundos");
            //Act
            //Assert
            Assert.True(cliente.Nome == "Leandro");

            Assert.NotNull(cliente);
        }

        [Fact]
        public void DeveAlterarNomeCliente()
        {
            //Arrange
            var cliente = new Cliente(nome: "Leandro", cpf: "10125485215", dataNascimento: DateTime.Now, logradouro: "Rua Apia", cep: "21214560", uf: "RJ",
                cidade: "Rio de Janeiro", bairro: "Vila da Penha", numero: 65, complemento: "Fundos");

            //Act
            cliente.AlterarNome("Pedro");

            //Assert
            Assert.True(cliente.Nome == "Pedro");
        }

        [Fact]
        public void DeveAlterarEnderecoCliente()
        {
            var cliente = new Cliente(nome: "Leandro", cpf: "10125485215", dataNascimento: DateTime.Now, logradouro: "Rua Apia", cep: "21214560", uf: "RJ",
                cidade: "Rio de Janeiro", bairro: "Vila da Penha", numero: 65, complemento: "Fundos");

            cliente.AlterarEndereco("Rua Feliciano Pena", "21221450", "RJ", "Rio de Janeiro", "Vila da Penha", 538, "Fundos");

            Assert.True(cliente.Logradouro == "Rua Feliciano Pena");
            Assert.True(cliente.Cep == "21221450");
            Assert.True(cliente.Uf == "RJ");
            Assert.True(cliente.Cidade == "Rio de Janeiro");
            Assert.True(cliente.Bairro == "Vila da Penha");
            Assert.True(cliente.Numero == 538);
            Assert.True(cliente.Complemento == "Fundos");

        }
    }
}
