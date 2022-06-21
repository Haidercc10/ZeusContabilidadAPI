using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ProveedoresCuenta
    {
        public string IdProve { get; set; } = null!;
        public string IdMoneda { get; set; } = null!;
        public string? Codicta { get; set; }
        public string? CodictaProvision { get; set; }
        public int IdenProveedoresCuentas { get; set; }
    }
}
