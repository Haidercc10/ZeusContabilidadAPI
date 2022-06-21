using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerColmena
    {
        public decimal Iden { get; set; }
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string CodBanco { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string Mostrar { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual Tercero CodTerceroNavigation { get; set; } = null!;
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
    }
}
