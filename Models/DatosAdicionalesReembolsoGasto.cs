using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DatosAdicionalesReembolsoGasto
    {
        public DatosAdicionalesReembolsoGasto()
        {
            FactdocBodies = new HashSet<FactdocBody>();
        }

        public int Id { get; set; }
        public string IdFuente { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public string? TipoProveedorTercero { get; set; }
        public string? Proveedor { get; set; }
        public string? ProveedorNombre { get; set; }
        public string? TipoFactura { get; set; }
        public string? Factura { get; set; }
        public string? Vencimiento { get; set; }
        public string? Referencia { get; set; }
        public string? Fecha { get; set; }
        public string? AreaImpresion { get; set; }
        public string? PuntoEmision { get; set; }
        public string? Secuencial { get; set; }
        public string? Autorizacion { get; set; }
        public int IdentificadorDocumentosAdicionales { get; set; }
        public int NoValidarTerceroProveedor { get; set; }
        public int UsarDatosProveedor { get; set; }

        public virtual ICollection<FactdocBody> FactdocBodies { get; set; }
    }
}
