using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TempCajaChica
    {
        public decimal Iden { get; set; }
        public int Tipo { get; set; }
        public string Rendicion { get; set; } = null!;
        public string FechaCaja { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string CuentaCxP { get; set; } = null!;
        public string TipoFacturaCxP { get; set; } = null!;
        public string NumFacturaCxP { get; set; } = null!;
        public string SerieFacturaCxP { get; set; } = null!;
        public string VencimientoCxP { get; set; } = null!;
        public string ReferenciaCxP { get; set; } = null!;
        public string FechaFacturaCxP { get; set; } = null!;
        public string CuentaCxC { get; set; } = null!;
        public string TipoFacturaCxC { get; set; } = null!;
        public string NumFacturaCxC { get; set; } = null!;
        public string SerieFacturaCxC { get; set; } = null!;
        public string VencimientoCxC { get; set; } = null!;
        public string ReferenciaCxC { get; set; } = null!;
        public string FechaFacturaCxC { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public string NumFactura { get; set; } = null!;
        public string SerieFactura { get; set; } = null!;
        public string VencimientoFactura { get; set; } = null!;
        public string ReferenciaFactura { get; set; } = null!;
        public string FechaFactura { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public decimal Redondeo { get; set; }
        public string DocumentoAsociado { get; set; } = null!;
        public string FechaContable { get; set; } = null!;
        public string ConceptoContable { get; set; } = null!;
        public decimal ValorConcepto { get; set; }
        public decimal? ValorImpuesto { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool BlDetraccion { get; set; }
        public string? CodigoDetraccion { get; set; }
        public string DepositoDetraccion { get; set; } = null!;
        public decimal PorcentajeDetraccion { get; set; }
        public decimal ImporteDetraccion { get; set; }
        public DateTime FechaDetraccion { get; set; }
        public string TipoOperaDetracion { get; set; } = null!;
        public string FechaVencimiento { get; set; } = null!;
        public decimal ValorInicialEmpleado { get; set; }
        public string CuentaAnticipo { get; set; } = null!;
        public string AuxiliarAnticipo { get; set; } = null!;
        public string? CentroCosto { get; set; }
        public string? Item { get; set; }
        public string FuenteEgreso { get; set; } = null!;
        public string DocumentoEgreso { get; set; } = null!;
        public string FuenteNota { get; set; } = null!;
        public string DocumentoNota { get; set; } = null!;
        public decimal Idprogramacion { get; set; }
        public decimal Consecutivo { get; set; }
        public int Estado { get; set; }
        public string? AuxiliarConcepto { get; set; }
    }
}
