using Generico.Domain.Account.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Domain.Base.ValueObject
{
    public class CpfCnpj
    {
        public string Valor { get; set; }
        public CpfCnpj()
        {

        }

        public CpfCnpj(string valor)
        {
            this.Valor = valor ?? throw new ArgumentNullException(nameof(Email));
        }
    }
}
