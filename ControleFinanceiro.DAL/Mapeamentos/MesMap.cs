﻿using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {
        public void Configure(EntityTypeBuilder<Mes> builder)
        {
            // Chave primária
            builder.HasKey(m => m.MesId);

            // Nome é obrigatório, caso queira que aceite null coloque IsRequired(false)
            // HasMaxLength = tamanho do campo
            builder.Property(m => m.Nome).IsRequired().HasMaxLength(20);
            builder.HasIndex(m => m.Nome).IsUnique(); // nome não pode repetir

            // Uma despesa esta relacionado a um mes, mas um mês pode estar relacionado a várias despesas
            builder.HasMany(m => m.Despesas).WithOne(m => m.Mes);

            // Um ganho esta relacionado a um mes, mas um mês pode estar relacionado a vários ganhos
            builder.HasMany(m => m.Ganhos).WithOne(m => m.Mes);

            // Adicionar dados na tabela
            builder.HasData(
                new Mes
                {
                    MesId = 1,
                    Nome = "Janeiro"
                },
                new Mes
                {
                    MesId = 2,
                    Nome = "Fevereiro"
                },

                new Mes
                {
                    MesId = 3,
                    Nome = "Março"
                },
                new Mes
                {
                    MesId = 4,
                    Nome = "Abril"
                },
                new Mes
                {
                    MesId = 5,
                    Nome = "Maio"
                },
                new Mes
                {
                    MesId = 6,
                    Nome = "Junho"
                },
                new Mes
                {
                    MesId = 7,
                    Nome = "Julho"
                },
                new Mes
                {
                    MesId = 8,
                    Nome = "Agosto"
                },
                new Mes
                {
                    MesId = 9,
                    Nome = "Setembro"
                },
                new Mes
                {
                    MesId = 10,
                    Nome = "Outubro"
                },
                new Mes
                {
                    MesId = 11,
                    Nome = "Novembro"
                },
                new Mes
                {
                    MesId = 12,
                    Nome = "Dezembro"
                });

            // Nome da tabela
            builder.ToTable("Meses");
        }
    }
}
