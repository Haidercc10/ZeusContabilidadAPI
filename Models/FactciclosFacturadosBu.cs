using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactciclosFacturadosBu
    {
        public decimal Iden { get; set; }
        public string Ciclo { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public DateTime UltimaFechaFact { get; set; }
        public decimal FacturacionAuto { get; set; }
    }
}
