using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar.Testes
{
    [TestClass]
    public class TestesValidarInteiros
    {
        [TestMethod]
        public void RetornarErroSeValorZerado() => Assert.IsTrue(new Validar().SeZero(0, "Obrigatório informar um valor maior que zero.").Falhou());

        [TestMethod]
        public void RetornarErroSeValorIgual() => Assert.IsTrue(new Validar().SeIgual(1, 1, "Os valores não podem ser iguais").Falhou());

        [TestMethod]
        public void RetornarErroSeValorMaiorQue() => Assert.IsTrue(new Validar().SeMaiorQue(1,0,"Informe um valor maior que zero").Falhou());

        [TestMethod]
        public void RetornarErroSeMaiorIgualQue() => Assert.IsTrue(new Validar().SeMaiorIgualQue(5, 5, "O número informado deve ser inferior a 5.").Falhou());

        [TestMethod]
        public void RetornarErroSeMenorQue() => Assert.IsTrue(new Validar().SeMenorQue(3, 5, "Numero informado é menor que 5.").Falhou());

        [TestMethod]
        public void RetornarErroSeMenorIgualQue() => Assert.IsTrue(new Validar().SeMenorIgualQue(10, 10, "Número informado deve ser menor que 10.").Falhou());

        [TestMethod]
        public void RetornarErroSeNumeroEntre() => Assert.IsTrue(new Validar().SeEntre(5, 1, 10, "Número informado nao pode estar entre 1 e 10.").Falhou());
    }
}
