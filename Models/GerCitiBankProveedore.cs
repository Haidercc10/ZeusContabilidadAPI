using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerCitiBankProveedore
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string CodigoBanco { get; set; } = null!;
        public int IdSucursalBanco { get; set; }
        public string DireccionBanco { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGercitibankProveedores { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual Tercero CodTerceroNavigation { get; set; } = null!;
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual GerCitiBankSucursale IdSucursalBancoNavigation { get; set; } = null!;
    }
}
