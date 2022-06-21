using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBanescoRepDominicanaProveedor
    {
        public string? IdProveedor { get; set; }
        public string? IdTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string? Banco { get; set; }
        public string? Cuenta { get; set; }
        public string? TipoCuenta { get; set; }
        public int? IndBanco { get; set; }
        public string? CodigoMatricula { get; set; }
        public int? Principal { get; set; }
        public int IdenGerbanescorepdominicanaProveedor { get; set; }

        public virtual GerBanescoRepDominicanaBanco? BancoNavigation { get; set; }
        public virtual Proveedore? IdProveedorNavigation { get; set; }
        public virtual Tercero? IdTerceroNavigation { get; set; }
    }
}
