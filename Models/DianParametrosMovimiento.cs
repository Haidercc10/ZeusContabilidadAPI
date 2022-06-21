using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DianParametrosMovimiento
    {
        public string Ano { get; set; } = null!;
        public string CodigodeInformacion { get; set; } = null!;
        public string Idvariable { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? RangosdeFuentes { get; set; }
        public string? RangosdeFechas { get; set; }
        public string? RangosdeCuentas { get; set; }
        public string Naturaleza { get; set; } = null!;
        public string? TipodeCuenta { get; set; }
        public decimal MinimoaReportar { get; set; }
        public bool InformacionExterior { get; set; }
        public bool? ConsolidaMinimo { get; set; }
        public string? CodInfMinimo { get; set; }
        public string? RazonMinimo { get; set; }
        public string? NitMinimo { get; set; }
        public short? TipoNitExterior { get; set; }
        public bool? SiSumaEncab { get; set; }
        public int IdenDianparametrosmovimiento { get; set; }
    }
}
