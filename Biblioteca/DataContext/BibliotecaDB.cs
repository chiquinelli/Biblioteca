using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteca.DataContext
{
    public class BibliotecaDB : DbContext
    {
        //aqui usando o entity framework estou criando como se fosse tabelas no banco
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        //tools nuget console e digitei enable-migrations e ele cria um banco de dados no projeto
        
    }
}