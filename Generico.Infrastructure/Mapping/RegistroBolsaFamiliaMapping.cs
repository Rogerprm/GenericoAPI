using Generico.Domain.Account;
using Generico.Domain.Registro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Infrastructure.Mapping
{
    public class RegistroBolsaFamiliaMapping : IEntityTypeConfiguration<RegistroBolsaFamilia>
    {
        public void Configure(EntityTypeBuilder<RegistroBolsaFamilia> builder)
        {
            builder.ToTable("TBREGISTROS");
            builder.HasKey(x => x.IdRegistro);
            builder.Property(x => x.IdRegistro).ValueGeneratedOnAdd();
            builder.Property(x => x.MesCompetencia);
            builder.Property(x => x.MesReferencia);
            builder.Property(x => x.UF);
            builder.Property(x => x.CdMunicipioSIAFI);
            builder.Property(x => x.NmMunicipio);
            builder.Property(x => x.CPFFavorecido);
            builder.Property(x => x.NISFavorecido);
            builder.Property(x => x.NomeFavorecido);
            builder.Property(x => x.ValorParcela);
        }
    }
}
