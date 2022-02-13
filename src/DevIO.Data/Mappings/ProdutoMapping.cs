using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(keyExpression: p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("varchar(200)");

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnName("varchar(1000)");

            builder.Property(p => p.Imagem)
                   .IsRequired()
                   .HasColumnName("varchar(100)");
            builder.ToTable("Produtos");
        }
    }
}
