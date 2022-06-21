using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpuestosXFactura
    {
        public string Codicta { get; set; } = null!;
        public string Tipofac { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencefac { get; set; } = null!;
        public string? Refefac { get; set; }
        public decimal? Valortra { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string Tercero { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public decimal? Porcimp { get; set; }
        public decimal? Baseimp { get; set; }
        public string Anomesimpfac { get; set; } = null!;
        public int IdenImpuestosXFacturas { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
    }
}
