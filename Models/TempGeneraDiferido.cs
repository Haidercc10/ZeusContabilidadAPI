using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TempGeneraDiferido
    {
        public string? No { get; set; }
        public string? Identificacion { get; set; }
        public string? Cuenta { get; set; }
        public string? Detalle { get; set; }
        public string? Fuente { get; set; }
        public decimal? ValorMes { get; set; }
        public string? CodigoMto { get; set; }
        public string? DescripcionMto { get; set; }
        public string? Dbcrmto { get; set; }
        public decimal? ValorMto { get; set; }
        public string? CentroCostoMto { get; set; }
        public string? AuxAbiertoMto { get; set; }
        public string? TerceroMto { get; set; }
        public string? ItemMto { get; set; }
        public string? IdentificacionMto { get; set; }
        public string? FuenteMto { get; set; }
        public int IdenTempgeneradiferido { get; set; }
    }
}
