using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    public partial class Validar
    {


        public Validar SeNuloOuVazio(string sValor, string sMensagem)
        {
            if (string.IsNullOrEmpty(sValor))
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeIgual(string sValor1, string sValor2, string sMensagem)
        {
            if (sValor1.ToLower() == sValor2.ToLower())
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMaiorQue(string sValor, int tamanho, string sMensagem)
        {

            if (sValor.Trim().Length > tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMaiorIgualQue(string sValor, int tamanho, string sMensagem)
        {

            if (sValor.Trim().Length >= tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMenorQue(string sValor, int tamanho, string sMensagem)
        {

            if (sValor.Trim().Length < tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMenorIgualQue(string sValor, int tamanho, string sMensagem)
        {

            if (sValor.Trim().Length <= tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeEntre(string valor, string conteudo, string sMensagem)
        {
            if (valor.IndexOf(conteudo) >= 0)
                this.Erros.Add(sMensagem);

            return this;
        }

    }
}
