using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carshop
{
    public class Format
    {
        static public string FormatarCPF(string cpf)
        {
            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
            {
                throw new ArgumentException("CPF inválido");
            }

            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        static public string FormatarTelefone(string telefone)
        {
            if (string.IsNullOrEmpty(telefone) ||  telefone.Length != 10)
            {
                throw new ArgumentException("Número de telefone inválido");
            }
            return string.Format("({0}) {1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 5), telefone.Substring(5));
        }
        static public string FormatarCNPJ(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj) || cnpj.Length != 14)
            {
                throw new ArgumentException("CNPJ inválido");
            }

            return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
        }
    }
}
