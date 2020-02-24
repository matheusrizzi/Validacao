using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar.Testes
{
    public class Pessoa:Validada
    {
        public Pessoa(string nome, int idade, DateTime dataNascimento, DateTime dataCadastro, string cpf)
        {
            Nome = nome;
            Idade = idade;
            DataCadastro = dataCadastro;
            DataNascimento = dataNascimento;
            Cpf = cpf;

            //Pode ser adicionada a validação a parte, caso queira validar por propriedades
            AdicionarValidacao(new Validar()
                                    .SeNuloOuVazio(nome, "Informe um nome válido!")
                                    .SeMenorQue(nome, 3, "O nome deverá conter no mínimo 3 caracteres.")
                                    .SeIgual(nome, "teste", "O nome nao pode ser teste!"));

            //Também poderá ser feita toda validação no mesmo método
            AdicionarValidacao(new Validar()
                                    .SeZero(idade, "Informe a idade da pessoa.")
                                    .SeMenorQue(idade, 18, "A pessoa deve ser maior de idade(18).")
                                    .SeMenorQue(dataCadastro, DateTime.Now, "A data de cadastro nao pode ser inferior a data de hoje.")
                                    .SeMaiorIgualQue(dataNascimento, dataCadastro, "Data de nascimento nao pode ser maior ou igual a data de cadastro.")
                                    .SeCpfValido(cpf,"Informe um cpf valido!")
                                    .SeDoctoValido(cpf, "Informe um documento valido!")
                );
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime DataCadastro { get; private set; }

    }

    [TestClass]
    public class Teste_Exemplo_Validacao_Dominio
    {
        [TestMethod]
        public void RetornarErroValidacaoDominiosRicos()
        {
            var funcionario = new Pessoa("xpto",18, DateTime.Now ,DateTime.Now,"99999999999");
            Assert.IsTrue(funcionario.Falhou, funcionario.RetornoValidacao());
        }
    }
}
