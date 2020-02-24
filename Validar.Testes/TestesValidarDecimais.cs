using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar.Testes
{
    [TestClass]
    public class TestesValidarDecimais
    {
        [TestMethod]
        public void RetornarErroSeValorZerado() => Assert.IsTrue(new Validar().SeZero(0, "Obrigatório informar um valor maior que zero.").Falhou());

        [TestMethod]
        public void RetornarErroSeValorIgual() => Assert.IsTrue(new Validar().SeIgual((decimal)1.55, (decimal)1.55, "Os valores não podem ser iguais").Falhou());

        [TestMethod]
        public void RetornarErroSeValorMaiorQue() => Assert.IsTrue(new Validar().SeMaiorQue((decimal)0.5, 0, "Valor informado nao pode ser maior que zero.").Falhou());

        [TestMethod]
        public void RetornarErroSeMaiorIgualQue() => Assert.IsTrue(new Validar().SeMaiorIgualQue((decimal)5.5, 5, "O número informado deve ser inferior a 5.").Falhou());

        [TestMethod]
        public void RetornarErroSeMenorQue() => Assert.IsTrue(new Validar().SeMenorQue((decimal)5.15, (decimal)5.25, "Numero informado é menor que 5,25.").Falhou());

        [TestMethod]
        public void RetornarErroSeMenorIgualQue() => Assert.IsTrue(new Validar().SeMenorIgualQue((decimal)10, (decimal)10, "Número informado deve ser menor que 10.").Falhou());

        [TestMethod]
        public void RetornarErroSeNumeroEntre() => Assert.IsTrue(new Validar().SeEntre((decimal)5, (decimal)1, (decimal)10, "Número informado nao pode estar entre 1 e 10.").Falhou());
    }
}
