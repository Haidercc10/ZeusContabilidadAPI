using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CambioFactura
    {
        public string FuenteO { get; set; } = null!;
        public string DocumentoO { get; set; } = null!;
        public string TipoFacturaO { get; set; } = null!;
        public string NumeroFacturaO { get; set; } = null!;
        public string ReferenciaO { get; set; } = null!;
        public string SerieO { get; set; } = null!;
        public string? AutorizacionO { get; set; }
        public string FechaCaducidadO { get; set; } = null!;
        public string Ncfo { get; set; } = null!;
        public string ComprobanteImpuestoO { get; set; } = null!;
        public int IdenAutorizacionO { get; set; }
        public string FuenteNew { get; set; } = null!;
        public string DocumentoNew { get; set; } = null!;
        public string FechaNew { get; set; } = null!;
        public string TipoFacturaNew { get; set; } = null!;
        public string NumeroFacturaNew { get; set; } = null!;
        public string ReferenciaNew { get; set; } = null!;
        public string SerieNew { get; set; } = null!;
        public string? AutorizacionNew { get; set; }
        public string FechaCaducidadNew { get; set; } = null!;
        public string Ncfnew { get; set; } = null!;
        public string ComprobanteImpuestoNew { get; set; } = null!;
        public int IdenAutorizacionNew { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FehaGrabacion { get; set; }
        public string Estado { get; set; } = null!;
        public int IdenCambiofactura { get; set; }
    }
}
