using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(keyExpression: p => p.Id);

            builder.Property(c => c.Logradouro)
                .IsRequired()
                .HasColumnName("varchar(200)");

            builder.Property(c => c.Numero)
                .IsRequired()
                .HasColumnName("varchar(50)");

            builder.Property(c => c.Cep)
                .IsRequired()
                .HasColumnName("varchar(8)");

            builder.Property(c => c.Complemento)
                .IsRequired()
                .HasColumnName("varchar(250)");

            builder.Property(c => c.Bairro)
                .IsRequired()
                .HasColumnName("varchar(100)");

            builder.Property(c => c.Cidade)
                .IsRequired()
                .HasColumnName("varchar(100)");

            builder.Property(c => c.Estado)
                .IsRequired()
                .HasColumnName("varchar(50)");

            builder.ToTable("Enderecos");
        }
    }
}
