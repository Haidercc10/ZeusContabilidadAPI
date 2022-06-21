using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Ger07proveedore
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string Banco { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string LugarPago { get; set; } = null!;
        public string TipoTransaccion { get; set; } = null!;
        public string TipoReferencia { get; set; } = null!;
        public string DescReferencia { get; set; } = null!;
        public string Mostrar { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGer07proveedores { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
    }
}
