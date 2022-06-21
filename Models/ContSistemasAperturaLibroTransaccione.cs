using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContSistemasAperturaLibroTransaccione
    {
        public decimal Iden { get; set; }
        public decimal IdenSaldo { get; set; }
        public string Detalle { get; set; } = null!;
        public decimal ValorTra { get; set; }
        public decimal? IdenRelacionado { get; set; }
        public int TipoTransaccion { get; set; }
        public string? Revelacion { get; set; }
    }
}
