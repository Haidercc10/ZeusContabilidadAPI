using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactModeloDatosAdiconalesTransaccion
    {
        public decimal Iden { get; set; }
        public string Idcliente { get; set; } = null!;
        public string IdDocumento { get; set; } = null!;
        public string IdModelo { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public decimal IdenMaestro { get; set; }
        public decimal IdenVariable { get; set; }
        public decimal? ValorNumerico { get; set; }
        public DateTime? ValorFecha { get; set; }
        public string? ValorVarchar { get; set; }
    }
}
