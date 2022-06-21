using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoBolivarianoProv
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public int IdBanco { get; set; }
        public string TipoCuenta { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string TipoMatricula { get; set; } = null!;
        public bool IndDigVerif { get; set; }
        public string? RealTipoCta { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerbancobolivarianoProv { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual Tercero CodTerceroNavigation { get; set; } = null!;
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual GerBancoBolivarianoBanco IdBancoNavigation { get; set; } = null!;
    }
}
