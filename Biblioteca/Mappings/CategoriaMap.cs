using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            //Define o nome da tabela
            builder.ToTable("Categoria");

            //Definir a Chave primaria
            builder.HasKey(p => p.Id);

            //Define o tamanho da coluna Nome e disse que é obrigatorio
            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            //Cria algumas categorias
            builder.HasData(
                new Categoria(1, "Ação"),
                new Categoria(2, "Crime")
                );
            
        }
    }
}
