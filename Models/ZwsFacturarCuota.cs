using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZwsFacturarCuota
    {
        public int Iden { get; set; }
        public int? SpId { get; set; }
        public int? IdenHead { get; set; }
        public int? Cuotas { get; set; }
        public string? VencimientoInicial { get; set; }
        public decimal? Valor { get; set; }
        public decimal? ValorMoneda { get; set; }
        public string? CodigoCxC { get; set; }
        public string? Bu { get; set; }
    }
}
