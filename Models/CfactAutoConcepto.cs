using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfactAutoConcepto
    {
        public decimal Iden { get; set; }
        public decimal IdenFacturacion { get; set; }
        public decimal Consecutivo { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal ValorUnidad { get; set; }
        public decimal ValorUnidadMoneda { get; set; }
        public decimal TasaCambio { get; set; }
        public decimal SubTotal { get; set; }
        public decimal PorcentajeDcto { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal TotalDescuento { get; set; }
        public decimal TotalIva { get; set; }
        public decimal Total { get; set; }
        public int Aplicado { get; set; }

        public virtual Factconc ConceptoNavigation { get; set; } = null!;
        public virtual CfactAutoNovedade IdenFacturacionNavigation { get; set; } = null!;
        public virtual Proveedore ProveedorNavigation { get; set; } = null!;
    }
}
