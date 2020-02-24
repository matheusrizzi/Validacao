using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    public partial class Validar
    {
        public Validar EhVerdadeiro(bool valor, string mensagem)
        {
            if (valor)
                this.Erros.Add(mensagem);

            return this;
        }

        public Validar EhFalso(bool valor, string mensagem)
        {
            if (!valor)
                this.Erros.Add(mensagem);

            return this;
        }

        public Validar SeIgual(bool valor1, bool valor2, string mensagem)
        {
            if (valor1 == valor2)
                this.Erros.Add(mensagem);

            return this;
        }
    }
}
