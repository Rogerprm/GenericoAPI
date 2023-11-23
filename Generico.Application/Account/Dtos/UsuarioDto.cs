using Generico.Domain.Account.Enum;
using Generico.Domain.Account.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Application.Account.Dtos
{
    public class UsuarioDto
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
    }
}
