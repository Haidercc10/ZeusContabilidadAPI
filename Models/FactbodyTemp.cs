using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactbodyTemp
    {
        public decimal Id { get; set; }
        public string Concepto { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string? Ccosto { get; set; }
        public string? AuxBto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal VrUnidad { get; set; }
        public decimal VrUnidadMoneda { get; set; }
        public decimal SubTotal { get; set; }
        public decimal PorDcto { get; set; }
        public decimal PorIva { get; set; }
        public decimal TotalDcto { get; set; }
        public decimal TotalIva { get; set; }
        public decimal Total { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Cliprv { get; set; }
        public string? Tdcto { get; set; }
        public string? Doc { get; set; }
        public string? Vcto { get; set; }
        public string? Ref { get; set; }
        public string? Unidad1 { get; set; }
        public string? Unidad2 { get; set; }
        public string? Unidad3 { get; set; }
        public decimal? VrUnidad1 { get; set; }
        public decimal? VrUnidad2 { get; set; }
        public decimal? VrUnidad3 { get; set; }
        public int? Automatico { get; set; }
        public int Procesado { get; set; }
        public string? Bu { get; set; }
        public string? Item { get; set; }
    }
}
