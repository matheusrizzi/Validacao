using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Validar.Testes
{
    [TestClass]
    public class TestesValidarStrings
    {
        [TestMethod]
        public void RetornarErroSeVazio() => Assert.IsTrue(new Validar().SeNuloOuVazio("", "Informe uma descricao.").Falhou());

        [TestMethod]
        public void RetornarSucessoSeNaoEstiverNuloOuVazio()=> Assert.IsTrue(new Validar().SeNuloOuVazio("xpto", "Informe uma descricao.").Ok());

        [TestMethod]
        public void RetornarErroSeVariaveisIguais()
        {
            var Descricao1 = "xpto";
            var Descricao2 = "XPTO";
            var validacao = new Validar().SeIgual(Descricao1, Descricao2, "As descricoes nao conferem");
            Assert.IsTrue(validacao.Falhou());
        }

        [TestMethod]
        public void RetornarSucessoSeVariaveisDiferentes()
        {
            var Descricao1 = "xpto1";
            var Descricao2 = "XPTO";
            var validacao = new Validar().SeIgual(Descricao1, Descricao2, "As descricoes nao conferem");
            Assert.IsTrue(validacao.Ok());
        }

        [TestMethod]
        public void RetornarErroSeTamanhoMaiorQue()
        {
            var Descricao1 = "foobar";
            var validacao = new Validar().SeMaiorQue(Descricao1, 3, "A descricao deverá conter mais que 3 caracteres.");
            Assert.IsTrue(validacao.Falhou());
        }

        [TestMethod]
        public void RetornarErroSeTamanhoMaiorIgualQue()
        {
            var Descricao1 = "foobar";
            var validacao = new Validar().SeMaiorIgualQue(Descricao1, 3, "A descricao deverá conter mais que 3 caracteres.");
            Assert.IsTrue(validacao.Falhou());
        }

        [TestMethod]
        public void RetornarErroSeTamanhoMenorQue()
        {
            var descricao = "fo";
            var validacao = new Validar()
                .SeMenorQue(descricao, 3, "A descrição deve ter no mínimo 3 caracteres.");
            Assert.IsTrue(validacao.Falhou());
        }

        [TestMethod]
        public void RetornarErroSeTamanhoMenorIgualQue()
        {
            var descricao = "foo";
            var validacao = new Validar()
                .SeMenorIgualQue(descricao, 3, "A descrição deve ter mais que 3 caracteres.");
            Assert.IsTrue(validacao.Falhou());
        }

        [TestMethod]
        public void RetornarErroSeTextoEntre()
        {
            var validacao = new Validar().SeEntre("abcdef", "cd", "Nao foi encontrado o texto.");
            Assert.IsTrue(validacao.Falhou());
        }
    }
}
