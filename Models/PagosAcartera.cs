using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PagosAcartera
    {
        public int Iden { get; set; }
        public string? Cliente { get; set; }
        public string? Proveedor { get; set; }
        public string? Cuenta { get; set; }
        public string? TipoFactura { get; set; }
        public string? NumeroFactura { get; set; }
        public string? Referencia { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? Estado { get; set; }

        public virtual Cliente? ClienteNavigation { get; set; }
        public virtual Maecont? CuentaNavigation { get; set; }
        public virtual Document? Document { get; set; }
        public virtual Fuente? FuenteNavigation { get; set; }
        public virtual Proveedore? ProveedorNavigation { get; set; }
        public virtual Tipofact? TipoFacturaNavigation { get; set; }
    }
}
