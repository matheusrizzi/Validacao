using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    public partial class Validar
    {
        public Validar SeNuloOuVazio(long valor, string sMensagem)
        {
            if (valor == 0)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeZero(long valor, string sMensagem)
        {
            if (valor == 0)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeIgual(long valor1, long valor2, string sMensagem)
        {
            if (valor1 == valor2)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMaiorQue(long valor, long tamanho, string sMensagem)
        {

            if (valor > tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMaiorIgualQue(long valor, long tamanho, string sMensagem)
        {

            if (valor >= tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMenorQue(long valor, long tamanho, string sMensagem)
        {

            if (valor < tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMenorIgualQue(long valor, long tamanho, string sMensagem)
        {

            if (valor <= tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeEntre(long valor, long date1, long date2, string sMensagem)
        {
            if (valor >= date1 && valor <= date2)
                this.Erros.Add(sMensagem);

            return this;
        }
    }
}
