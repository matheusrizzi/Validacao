using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    public partial class Validar
    {
        public Validar SeCnpjValido(string cnpj, string mensagem)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
            {
                this.Erros.Add(mensagem);
                return this;
            }

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            var cnpjValido = cnpj.EndsWith(digito);

            if (!cnpjValido)
                this.Erros.Add(mensagem);

            return this;
        }

        public Validar SeCpfValido(string cpf, string mensagem)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                this.Erros.Add(mensagem);
                return this;
            }

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            if (!cpf.EndsWith(digito))
                this.Erros.Add(mensagem);

            return this;
        }

        public Validar SeDoctoValido(string cpfCnpj, string mensagem)
        {
            var docto = cpfCnpj.Trim();
            docto = docto.Replace(".", "").Replace("-", "");

            if (docto.Length <= 11)
                return SeCpfValido(docto, mensagem);

            return SeCnpjValido(docto, mensagem);
        }

        public Validar SePisValido(string pis, string mensagem)
        {
            pis = pis.Trim();
            pis = pis.Replace("-", "").Replace(".", "").PadLeft(11, '0');

            int[] multiplicador = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;

            if (pis.Trim().Length != 11)
            {
                this.Erros.Add(mensagem);
                return this;
            }



            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(pis[i].ToString()) * multiplicador[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            if (!pis.EndsWith(resto.ToString()))
                this.Erros.Add(mensagem);

            return this;
        }

        public Validar SeCep(string cep, string mensagem)
        {
            if (cep.Length == 8)
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);

            if (!System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}")))
                this.Erros.Add(mensagem);

            return this;
        }

        public Validar SeEmailInvalido(string email, string mensagem)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                var x = addr.Address == email;

                if (email.IndexOf(".com") == -1)
                    this.Erros.Add(mensagem);

            }
            catch
            {
                this.Erros.Add(mensagem);
            }
            return this;
        }
    }
}
