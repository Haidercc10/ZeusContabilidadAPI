using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosTipoRetencionIva
    {
        public decimal Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdenEscenariosTiporetencioniva { get; set; }
    }
}
