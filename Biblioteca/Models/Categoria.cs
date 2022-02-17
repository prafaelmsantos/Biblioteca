using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Categoria
    {
        public Categoria() { }
        
        public Categoria(int id, string nome): this()
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        //Diz me todos os livros de uma categoria x
        public virtual ICollection<Livro> Livros { get; set; }
    }

    
}
