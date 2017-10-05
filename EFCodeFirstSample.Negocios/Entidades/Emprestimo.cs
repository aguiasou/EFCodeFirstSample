using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSample.Negocios.Entidades
{
    public class Emprestimo : Entity
    {
        public DateTime DataEmprestimo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Exemplar Exemplar { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public bool FoiDevolvido => this.DataDevolucao.HasValue;
    }
}
