using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturasVsCobroLog
    {
        public decimal Iden { get; set; }
        public string Cuenta { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Operacion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal? IdenCobradorAnterior { get; set; }
        public decimal? IdenCobradorActual { get; set; }
        public string Bu { get; set; } = null!;

        public virtual Cliente ClienteNavigation { get; set; } = null!;
        public virtual Maecont CuentaNavigation { get; set; } = null!;
        public virtual ScCobrador? IdenCobradorActualNavigation { get; set; }
        public virtual ScCobrador? IdenCobradorAnteriorNavigation { get; set; }
        public virtual Tipofact TipoFacturaNavigation { get; set; } = null!;
        public virtual Usuario1 UsuarioNavigation { get; set; } = null!;
    }
}
