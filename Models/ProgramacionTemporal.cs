using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ProgramacionTemporal
    {
        public int? SpId { get; set; }
        public decimal? Consecutivo { get; set; }
        public short? Periodicidad { get; set; }
        public string? TipoConfiguracion { get; set; }
        public short? DiaCada { get; set; }
        public string? DiaSeleccionDia { get; set; }
        public short? MesCadaMes { get; set; }
        public short? MesCadaDia { get; set; }
        public string? MesSeleccionMes { get; set; }
        public int IdenProgramaciontemporal { get; set; }
    }
}
