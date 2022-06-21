using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TempAnticiposPrv
    {
        public int SpId { get; set; }
        public int IdProceso { get; set; }
        public string Cuenta { get; set; } = null!;
        public string Auxiliar { get; set; } = null!;
        public decimal ValorCruzado { get; set; }
        public int IdenTempanticiposprv { get; set; }
    }
}
