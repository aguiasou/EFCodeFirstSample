using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EFCodeFirstSample.Negocios.Entidades
{
    public class Livro : Entidade
    {
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Subtitulo { get; set; }
        public virtual ICollection<Autor> Autores { get; set; }
        public virtual ICollection<Categoria> Categorias { get; set; }

        public virtual ICollection<Exemplar> Exemplares { get; set; }


        public string Edicao { get; set; }
        public int Ano { get; set; }
    }
}
