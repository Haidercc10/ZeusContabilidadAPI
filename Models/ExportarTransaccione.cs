using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ExportarTransaccione
    {
        public string Cuenta { get; set; } = null!;
        public int Transaccion { get; set; }
        public string Campo { get; set; } = null!;
        public decimal Variables { get; set; }
        public string? Constante { get; set; }
        public int IdenExportarTransacciones { get; set; }
    }
}
