using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PlantillaItem
    {
        public string Plantilla { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string? IndTranDcto { get; set; }
        public string? ChangueFuente { get; set; }
        public string? ChangueFecha { get; set; }
        public string? ChangueTerceroD { get; set; }
        public string? ChangueDetalle { get; set; }
        public string? ChangueCuentaBasica { get; set; }
        public string? ChangueCentroBasico { get; set; }
        public string? ChangueAuxiliarBasico { get; set; }
        public string? ChangueItemBasico { get; set; }
        public string? ChangueCuenta { get; set; }
        public string? ChangueDescripcion { get; set; }
        public string? ChangueDbcr { get; set; }
        public string? ChangueValor { get; set; }
        public string? ChangueCentro { get; set; }
        public string? ChangueAuxiliar { get; set; }
        public string? ChangueItem { get; set; }
        public string? ChangueUnidad1 { get; set; }
        public string? ChangueUnidad2 { get; set; }
        public string? ChangueUnidad3 { get; set; }
        public string? ChangueValorUnidad1 { get; set; }
        public string? ChangueValorUnidad2 { get; set; }
        public string? ChangueValorUnidad3 { get; set; }
        public string? ChangueValorMoneda { get; set; }
        public string? ChangueTasaCambio { get; set; }
        public string? ChangueTercero { get; set; }
        public string? ChangueTipodoc { get; set; }
        public string? ChangueNumedoc { get; set; }
        public string? ChangueVencimiento { get; set; }
        public string? ChangueReferencia { get; set; }
        public string? ChangueVendedor { get; set; }
        public string? ChangueZona { get; set; }
        public string? ChangueEntidad { get; set; }
        public string? ChanguePlaza { get; set; }
        public string? ChanguePorceimpuesto { get; set; }
        public string? ChangueBaseValorImpuesto { get; set; }
        public string? ChangueRubroPresupuesto { get; set; }
        public string? ChangueReservaPresupuesto { get; set; }
        public int IdenPlantillaItems { get; set; }
    }
}
