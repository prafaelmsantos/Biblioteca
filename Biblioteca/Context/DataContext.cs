using Biblioteca.Mappings;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Context
{
    public class DataContext: DbContext
    {
        // Vai fazer a modelagem das entidades que vai virar tabela

        public DataContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new LivroMap());

       
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }



    }
}
