using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    public class CartaoMap : IEntityTypeConfiguration<Cartao>
    {
        public void Configure(EntityTypeBuilder<Cartao> builder)
        {
            // Chave Primária
            builder.HasKey(c => c.CartaoId);

            // Nome é obrigatório, caso queira que aceite null coloque IsRequired(false)
            // HasMaxLength = tamanho do campo
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(20);
            builder.HasIndex(c => c.Nome).IsUnique(); // nome não pode repetir

            builder.Property(c => c.Bandeira).IsRequired().HasMaxLength(15);

            builder.Property(c => c.Numero).IsRequired().HasMaxLength(20);
            builder.HasIndex(c => c.Numero).IsUnique(); // nome não pode repetir

            builder.Property(c => c.Limite).IsRequired();

            // Relacionamento
            builder.HasOne(c => c.Usuario).WithMany(c => c.Cartoes).HasForeignKey(c => c.UsuarioId).IsRequired().OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(c => c.Despesas).WithOne(c => c.Cartao);

            // Nome da tabela
            builder.ToTable("Cartoes");
        }
    }
}
