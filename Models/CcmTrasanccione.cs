using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmTrasanccione
    {
        public string Comprobante { get; set; } = null!;
        public string TipoOperacion { get; set; } = null!;
        public string DescripcionOperacion { get; set; } = null!;
        public string FechaOperacion { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string? ReferenciaDocumento { get; set; }
        public string? CodigoCliente { get; set; }
        public string Nit { get; set; } = null!;
        public string? TipoFactura { get; set; }
        public string? NumeroFactura { get; set; }
        public string? VencimientoFactura { get; set; }
        public string UnidadDeCuenta { get; set; } = null!;
        public string? CentroCosto { get; set; }
        public string NaturalezaTransaccion { get; set; } = null!;
        public decimal ValorTransacciones { get; set; }
        public string DetalleMovimiento { get; set; } = null!;
        public string? Usuario { get; set; }
        public string? Adicional1 { get; set; }
        public string? Adicional2 { get; set; }
    }
}
