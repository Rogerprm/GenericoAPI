using FluentValidation;
using Generico.Domain.Account.Enum;
using Generico.Domain.Account.Rules;
using Generico.Domain.Account.ValueObject;
using Generico.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Domain.Account
{
    public class Usuario : Entity<Guid>
    {
        public string Nome { get; set; }
        public Email Email { get; set;}
        public Password Password { get; set;}
        public TipoUsuarioEnum TipoUsuario { get; set;}

        //EF
        protected Usuario() { }    

        public void Update(string nome, Email email, Password password)
        {
            Email = email;
            Password = password;
            Nome= nome;
        }


        public void SetPassword()
        {
            this.Password.Valor = SecurityUtils.HashSHA256(this.Password.Valor);
        }

        public void Validate() => new UsuarioValidator().ValidateAndThrow(this);

    }
}
