using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    public abstract class Validada
    {
        private List<string> erros;
        public bool Ok => this.erros.Count == 0 ? true : false;
        public bool Falhou => this.erros.Count > 0 ? true : false;
        
        public string RetornoValidacao()
        {
            var sb = new StringBuilder();
            this.erros.ForEach(x => sb.AppendLine(x));
            return sb.ToString();
        }

        public Validada() => this.erros = new List<string>();

        public void AdicionarValidacao(Validar validacao) => this.erros.AddRange(validacao.Erros);

    }
}
