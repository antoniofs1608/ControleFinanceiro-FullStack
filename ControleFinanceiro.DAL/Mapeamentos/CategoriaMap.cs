using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            // Chave Primária
            builder.HasKey(c => c.CategoriaId);


            // Nome é obrigatório, caso queira que aceite null coloque IsRequired(false)
            // HasMaxLength = tamanho do campo
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Icone).IsRequired().HasMaxLength(15);

            // Chave Extrangeira /tipo (HasIbe) pode ter várias cateogorias TipoId (WithMany)
            builder.HasOne(c => c.Tipo).WithMany(c => c.Categorias).HasForeignKey(c => c.TipoId).IsRequired();

            // Categoria pode estar relacionada a vários Ganhos e várias Despesas
            builder.HasMany(c => c.Ganhos).WithOne(c => c.Categoria);
            builder.HasMany(c => c.Despesas).WithOne(c => c.Categoria);

            // Nome da tabela
            builder.ToTable("Categorias");
        }
    }
}
