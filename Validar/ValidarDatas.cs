using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    public partial class Validar
    {
        public Validar SeNuloOuVazio(DateTime? valor, string sMensagem)
        {
            if (valor == null)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeZero(DateTime valor, string sMensagem)
        {
            if (valor == DateTime.MinValue)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeIgual(DateTime valor1, DateTime valor2, string sMensagem)
        {
            if (valor1.Date == valor2.Date)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMaiorQue(DateTime valor, DateTime tamanho, string sMensagem)
        {

            if (valor.Date > tamanho.Date)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMaiorIgualQue(DateTime valor, DateTime tamanho, string sMensagem)
        {

            if (valor.Date >= tamanho.Date)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMenorQue(DateTime valor, DateTime tamanho, string sMensagem)
        {

            if (valor.Date < tamanho.Date)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMenorIgualQue(DateTime valor, DateTime tamanho, string sMensagem)
        {

            if (valor.Date <= tamanho.Date)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeEntre(DateTime valor, DateTime date1, DateTime date2, string sMensagem)
        {
            if (valor.Date >= date1.Date && valor.Date <= date2.Date)
                this.Erros.Add(sMensagem);

            return this;
        }
    }
}
