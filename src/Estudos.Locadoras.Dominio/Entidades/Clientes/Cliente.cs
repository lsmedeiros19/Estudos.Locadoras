using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Locadoras.Dominio.Entidades.Clientes
{
    public class Cliente
    {

        public Cliente(string nome, string cpf, DateTime dataNascimento, string logradouro, string cep, string uf, string cidade, string bairro, int numero, string complemento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Logradouro = logradouro;
            Cep = cep;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;

            Validar();
        }

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public string Logradouro { get; private set; }

        public string Cep { get; private set; }

        public string Uf { get; private set; }

        public string Cidade { get; private set; }

        public string Bairro { get; private set; }

        public int Numero { get; private set; }

        public string Complemento { get; private set; }

        public void AlterarNome(string nome)
        {
            this.Nome = nome;
        }

        public void AlterarEndereco(string logradouro, string cep, string uf, string cidade, string bairro, int numero, string complemento)
        {
            this.Logradouro = logradouro;
            this.Cep = cep;
            this.Uf = uf;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Numero = numero;
            this.Complemento = complemento;

            Validar();
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new ArgumentException("Nome Obrigatório");
        }

    }
}
