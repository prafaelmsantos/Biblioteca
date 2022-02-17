using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Livro
    {
        public Livro() =>
            DataEntrada = DateTime.Now;
        
        public Livro(int id, int categoriaId, string titulo, string autor, int quantidade, double preco, DateTime dataEntrada): this()
        {
            Id = id;
            CategoriaId = categoriaId;
            Titulo = titulo;
            Autor = autor;
            Quantidade = quantidade;
            Preco = preco;
            DataEntrada = dataEntrada;
        }

        public Livro(int id, int categoriaId, string titulo, string autor, int quantidade, double preco): this()
        { //This chama o construtor vazio
            Id = id;
            CategoriaId = categoriaId;
            Titulo = titulo;
            Autor = autor;
            Quantidade = quantidade;
            Preco = preco;

        }

        public int Id { get; set; }
        public int CategoriaId { get; set; }
        //O EF Core cria uma chave estrangeira
        public Categoria Categoria { get; set; } 
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime DataEntrada { get; set; }

    }
}
