using EFCodeFirstSample.Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSample.Dados
{
    public class BibliotecaContext : DbContext
    {
       
        public BibliotecaContext(): base("name=Biblioteca")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Livro> Livros { get; set; }

        public DbSet<Exemplar> Exemplares { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
