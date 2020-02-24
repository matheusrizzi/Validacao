using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar.Testes
{
    [TestClass]
    public class TestesValidarLongs
    {
        [TestMethod]
        public void RetornarErroSeValorZerado() => Assert.IsTrue(new Validar().SeZero((long)0, "Obrigatório informar um valor maior que zero.").Falhou());

        [TestMethod]
        public void RetornarErroSeValorIgual() => Assert.IsTrue(new Validar().SeIgual((long)1, (long)1, "Os valores não podem ser iguais").Falhou());

        [TestMethod]
        public void RetornarErroSeValorMaiorQue() => Assert.IsTrue(new Validar().SeMaiorQue((long)1, (long)0, "Informe um valor maior que zero").Falhou());

        [TestMethod]
        public void RetornarErroSeMaiorIgualQue() => Assert.IsTrue(new Validar().SeMaiorIgualQue((long)5, (long)5, "O número informado deve ser inferior a 5.").Falhou());

        [TestMethod]
        public void RetornarErroSeMenorQue() => Assert.IsTrue(new Validar().SeMenorQue((long)3, (long)5, "Numero informado é menor que 5.").Falhou());

        [TestMethod]
        public void RetornarErroSeMenorIgualQue() => Assert.IsTrue(new Validar().SeMenorIgualQue((long)10, (long)10, "Número informado deve ser menor que 10.").Falhou());

        [TestMethod]
        public void RetornarErroSeNumeroEntre() => Assert.IsTrue(new Validar().SeEntre((long)5, (long)1, (long)10, "Número informado nao pode estar entre 1 e 10.").Falhou());
    }
}
