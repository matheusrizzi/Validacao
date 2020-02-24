using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar.Testes
{
    [TestClass]
    public class TestesValidarDiversos
    {
        [TestMethod]
        public void RetornarErroSeCnjpInvalido() => Assert.IsTrue(new Validar().SeCnpjValido("9999999999999", "Informe um cnpj valido").Falhou());

        [TestMethod]
        [DataRow("998.875.660-71")]
        [DataRow("81135750068")]
        [DataRow("27.719.877/0001-93")]
        [DataRow("88770533000101")]
        public void RetornarSucessoSeDocumentoValido(string documento) => Assert.IsTrue(new Validar().SeDoctoValido(documento, "Informe um docto valido.").Ok());

        [TestMethod]
        public void RetornarErroSeCpfInvalido() => Assert.IsTrue(new Validar().SeCpfValido("99912312312", "Inform eum cpf valido.").Falhou());

        [TestMethod]
        [DataRow("9999999999999")]
        [DataRow("123456")]
        [DataRow("000000000000")]
        [DataRow("25468954632")]
        public void RetornarErroSeDocumentoInvalido(string documento) => Assert.IsTrue(new Validar().SeDoctoValido(documento, "Informe um docto valido.").Falhou());

        [TestMethod]
        [DataRow("999999999")]
        [DataRow("111111111")]
        [DataRow("000000000")]
        public void RetornarErroSeCepInvalido(string cep) => Assert.IsTrue(new Validar().SeCep(cep, "Informe um cep valido.").Falhou());

        [TestMethod]
        [DataRow("89040-105")]
        [DataRow("89023350")]
        [DataRow("89095300")]
        public void RetornarSucessoSeCepValido(string cep) => Assert.IsTrue(new Validar().SeCep(cep, "Informe um cep valido.").Ok());

        [TestMethod]
        [DataRow("testes@xpto")]
        [DataRow("tstxpto.com.br")]
        [DataRow("tst@.br")]
        public void RetornarErroSeEmailInvalido(string email) => Assert.IsTrue(new Validar().SeEmailInvalido(email, "Informe um email valido.").Falhou());

        [TestMethod]
        [DataRow("438.90946.55-1")]
        [DataRow("588.18188.13-0")]
        [DataRow("32020163469")]
        public void RetornarSucessoSePisValido(string pis) => Assert.IsTrue(new Validar().SePisValido(pis, "Informe um pis valido.").Ok());

        [TestMethod]
        [DataRow("999.90946.55-1")]
        [DataRow("588.00000.13-0")]
        [DataRow("96540163469")]
        public void RetornarErroSePisValido(string pis) => Assert.IsTrue(new Validar().SePisValido(pis, "Informe um pis valido.").Falhou());
    }
}
