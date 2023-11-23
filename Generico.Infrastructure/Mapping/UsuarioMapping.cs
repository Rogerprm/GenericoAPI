using Generico.Domain.Account;
using Generico.Domain.Cadastro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Infrastructure.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x=> x.Nome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.TipoUsuario).IsRequired();

            builder.OwnsOne(x => x.Email, p =>
            {
                p.Property(f => f.Valor).HasColumnName("Email").IsRequired().HasMaxLength(200);
            });

            builder.OwnsOne(x => x.Password, p =>
            {
                p.Property(f => f.Valor).HasColumnName("Password").IsRequired().HasMaxLength(200);
            });
        }
    }
}


//Metodos para criar e consultar usuario no banco servico e interface de usuario