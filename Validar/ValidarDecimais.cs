using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    public partial class Validar
    {
        public Validar SeNuloOuVazio(decimal valor, string sMensagem)
        {
            if (valor == 0)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeZero(decimal valor, string sMensagem)
        {
            if (valor == 0)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeIgual(decimal valor1, decimal valor2, string sMensagem)
        {
            if (valor1 == valor2)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMaiorQue(decimal valor, decimal tamanho, string sMensagem)
        {

            if (valor > tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMaiorIgualQue(decimal valor, decimal tamanho, string sMensagem)
        {

            if (valor >= tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMenorQue(decimal valor, decimal tamanho, string sMensagem)
        {

            if (valor < tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMenorIgualQue(decimal valor, decimal tamanho, string sMensagem)
        {

            if (valor <= tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeEntre(decimal valor, decimal date1, decimal date2, string sMensagem)
        {
            if (valor >= date1 && valor <= date2)
                this.Erros.Add(sMensagem);

            return this;
        }
    }
}
