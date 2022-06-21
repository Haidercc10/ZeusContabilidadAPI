using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FbancolombiaSecuencium
    {
        public string Fecha { get; set; } = null!;
        public string Secuencia { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public int IdenFbancolombiaSecuencia { get; set; }
    }
}
