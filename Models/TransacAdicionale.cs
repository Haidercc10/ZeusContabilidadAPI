using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TransacAdicionale
    {
        public decimal? Consecutra { get; set; }
        public string? CompReteSerie { get; set; }
        public string? CompReteSecuencial { get; set; }
        public string? CompReteFechaEmision { get; set; }
        public string? CompReteAutorizacion { get; set; }
        public string? XmlAdicionales { get; set; }
        public string? IdMonedaRelacion { get; set; }
        public decimal? ValorMonedaRelacion { get; set; }
        public double? TasaDeCambioMonedaRelacion { get; set; }
        public int? ConsecutraMonedaRelacion { get; set; }
        public string? ReferenciaPorTransaccion { get; set; }
        public int IdenTransacAdicionales { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public string? UsuarioRecepcion { get; set; }
    }
}
