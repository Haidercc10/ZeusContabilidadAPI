using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EsquemaAplicacionesZeu
    {
        public decimal IdenEsquema { get; set; }
        public int IdAplicacionesZeus { get; set; }
        public int IdenEsquemaAplicacioneszeus { get; set; }

        public virtual Esquema IdenEsquemaNavigation { get; set; } = null!;
    }
}
