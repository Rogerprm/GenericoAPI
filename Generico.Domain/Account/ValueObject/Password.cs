using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Domain.Account.ValueObject
{
    public class Password
    {
        public string Valor { get; set; }
        public Password()
        {

        }

        public Password(string valor)
        {
            this.Valor = valor ?? throw new ArgumentNullException(nameof(Email));
        }
    }
}
