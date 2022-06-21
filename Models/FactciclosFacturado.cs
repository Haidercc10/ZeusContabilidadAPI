using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactciclosFacturado
    {
        public decimal Iden { get; set; }
        public string Ciclo { get; set; } = null!;
        public DateTime UltimaFechaFact { get; set; }
        public decimal FacturacionAuto { get; set; }
        public string Bu { get; set; } = null!;

        public virtual Factciclo CicloNavigation { get; set; } = null!;
    }
}
