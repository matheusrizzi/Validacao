using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    public partial class Validar
    {
        public Validar SeNuloOuVazio(int valor, string sMensagem)
        {
            if (valor == 0)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeZero(int valor, string sMensagem)
        {
            if (valor == 0)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeIgual(int valor1, int valor2, string sMensagem)
        {
            if (valor1 == valor2)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMaiorQue(int valor, int tamanho, string sMensagem)
        {

            if (valor > tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMaiorIgualQue(int valor, int tamanho, string sMensagem)
        {

            if (valor >= tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMenorQue(int valor, int tamanho, string sMensagem)
        {

            if (valor < tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeMenorIgualQue(int valor, int tamanho, string sMensagem)
        {

            if (valor <= tamanho)
                this.Erros.Add(sMensagem);

            return this;
        }

        public Validar SeEntre(int valor, int valor1, int valor2, string sMensagem)
        {
            if (valor >= valor1 && valor <= valor2)
                this.Erros.Add(sMensagem);

            return this;
        }
    }
}
