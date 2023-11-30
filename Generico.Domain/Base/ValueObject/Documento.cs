using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Domain.Base.ValueObject
{
    public class Documento
    {
        public string Valor { get; }

        public Documento(string valor)
        {

            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentNullException(nameof(valor));
            }

            string valorLimpo = new string(valor.Where(char.IsDigit).ToArray());

            if(valorLimpo.Length != 11 && valorLimpo.Length != 14)
            {
                throw new ArgumentException(" CPF/CNPJ deve ter 11 ou 14 dígitos.", nameof(valor));
            }

            //validações addicionais

            Valor = valorLimpo; 
        }

        
    }
}
