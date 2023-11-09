using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Domain.Account.Enum
{
    public enum TipoUsuarioEnum : int
    {
        [Description("Administrador")]
        Administrador = 1,

        [Description("Cliente")]
        Cliente = 2
    }
}
