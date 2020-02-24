using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    public partial class Validar
    {
        public List<string> Erros;

        public Validar() => this.Erros = new List<string>();

        public bool Falhou() => this.Erros.Count == 0 ? false : true;

        public bool Ok() => this.Erros.Count == 0 ? true : false;

        public override string ToString()
        {
            var sb = new StringBuilder();
            this.Erros.ForEach(x => sb.AppendLine(x));
            return sb.ToString();
        }
    }
}
