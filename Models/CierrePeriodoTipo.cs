using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CierrePeriodoTipo
    {
        public string? AnoMes { get; set; }
        public string? ParametroCierre { get; set; }
        public string? IdFuente { get; set; }
        public string? NumDocTra { get; set; }
        public int IdenCierreperiodotipo { get; set; }
    }
}
