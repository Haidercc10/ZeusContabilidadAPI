using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoEmailMaestro
    {
        public TipoEmailMaestro()
        {
            TipoEmails = new HashSet<TipoEmail>();
        }

        public decimal Iden { get; set; }
        public string Tabla { get; set; } = null!;
        public string Caption { get; set; } = null!;

        public virtual ICollection<TipoEmail> TipoEmails { get; set; }
    }
}
