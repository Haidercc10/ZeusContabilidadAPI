using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZwsMpgNomina
    {
        public decimal Iden { get; set; }
        public string Xmlvalue { get; set; } = null!;
        public string FechaProceso { get; set; } = null!;
        public string Respuesta { get; set; } = null!;
    }
}
