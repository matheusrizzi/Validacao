using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar.Testes
{
    [TestClass]
    public class TestesValidarDatas
    {
        [TestMethod]
        public void RetornarErroSeDataIsNull() 
        {
            DateTime? xpto = null;
            Assert.IsTrue(new Validar().SeNuloOuVazio(xpto, "A data informada nao pode ser nula!").Falhou());
        }

        [TestMethod]
        public void RetornarErroSeDataMinima() => new Validar().SeZero(DateTime.MinValue, "Informe uma data mais atual.").Falhou();

        [TestMethod]
        public void RetornarErroSeDatasIguais() => new Validar().SeIgual(DateTime.Now, DateTime.Now, "As datas não podem ser iguais.").Falhou();

        [TestMethod]
        public void RetornarErroSeDataInicialMaiorQueDataFinal() => new Validar()
                                                    .SeMaiorQue(DateTime.Now, DateTime.Now.AddDays(-5), "A data inicial nao pode ser superior a data final.").Falhou();

        [TestMethod]
        public void RetornarErroSeDataMaiorOuIgual() => new Validar().SeMaiorIgualQue(DateTime.Now, DateTime.Now, "A data inicial de veser inferior a final.").Falhou();

        [TestMethod]
        public void RetornarErroSeDataMenorQue() => new Validar()
                                                    .SeMenorQue(DateTime.Now, DateTime.Now.AddDays(3), "A data inicial nao pode ser menor que a data final.").Falhou();

        [TestMethod]
        public void RetornarErroSeDataEntre() => new Validar()
                                                .SeEntre(DateTime.Now.AddDays(5), DateTime.Now, DateTime.Now.AddDays(10), "data nao pode estar no intervalo.").Falhou();
    }
}
