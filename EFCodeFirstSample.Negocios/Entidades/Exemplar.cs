

using System;

namespace EFCodeFirstSample.Negocios.Entidades
{
    public class Exemplar :Entidade
    {
        public virtual Livro Livro { get; set; }
        public DateTime DataAquisicao { get; set; }

    }
}
