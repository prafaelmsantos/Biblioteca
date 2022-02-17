using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(p => p.Id);

            /* // Se eu quiser criar uma chave manualmente
            builder.Property(p => p.Id)
                .ValueGeneratedNever(); */

            builder.Property(p => p.Titulo)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Autor)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.DataEntrada)
                .HasColumnType("datetime");

            /* Tenho uma categoria para muios livros ( Ele por padrao ja faz isto)
            builder.HasOne(p => p.Categoria)
                .WithMany()
                .HasForeignKey(p => p.CategoriaId); */

            builder.HasData(
                new Livro(1, 1,"Spider Man","Peter Parker",4,25)
                );
        }
    }
}
