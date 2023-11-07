using Generico.Domain.Cadastro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Generico.Infrastructure.Mapping
{
    public class ApiCepMapping : IEntityTypeConfiguration<CepModel>
    {
        public void Configure(EntityTypeBuilder<CepModel> builder)
        {
            builder.ToTable("CepModels");
            builder.HasKey(x => x.Id); 
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.Cep).IsRequired(true).HasColumnName("Cep").HasMaxLength(9);
        }
    }
}
