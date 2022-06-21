using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PrestamosMora
    {
        public decimal IdPrestamoMora { get; set; }
        public decimal IdPrestamoD { get; set; }
        public decimal? Tasa { get; set; }
        public string AnoMes { get; set; } = null!;
        public string? Fecha { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? TipoFac { get; set; }
        public string? Numefac { get; set; }
        public string? Vencefac { get; set; }
        public string? Refefac { get; set; }
        public decimal? Valor { get; set; }
        public string? Estado { get; set; }
    }
}
