using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoNotaDbcr
    {
        public TipoNotaDbcr()
        {
            Factheads = new HashSet<Facthead>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal TipoNota { get; set; }
        public bool Deshabilitado { get; set; }

        public virtual ICollection<Facthead> Factheads { get; set; }
    }
}
