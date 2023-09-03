using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    public class TipoMap : IEntityTypeConfiguration<Tipo>
    {
        public void Configure(EntityTypeBuilder<Tipo> builder)
        {
            // Chave primária
            builder.HasKey(t => t.TipoId);

            // Nome é obrigatório, caso queira que aceite null coloque IsRequired(false)
            // HasMaxLength = tamanho do campo
            builder.Property(t => t.Nome).IsRequired().HasMaxLength(20);

            // HasMany = um Tipo pode ter várias (N) Categorias
            // WithOne = uma Categopria pode ter apenas um Tipo
            builder.HasMany(t => t.Categorias).WithOne(t => t.Tipo);

            // Quando criar o banco de dados vai adicionar esses dois dados na tabela
            builder.HasData(
                new Tipo
                {
                    TipoId = 1,
                    Nome = "Despesa"
                },
                new Tipo
                {
                    TipoId = 2,
                    Nome = "Ganho"
                });

            // Nome da tabela, a classe chama Tipo mas quando for mapeado no banco de dados vai ser Tipos
            builder.ToTable("Tipos");
        }
    }
}
