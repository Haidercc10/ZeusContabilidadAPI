using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoHsbcColombiaProv
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public string IdBanco { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
        public string? Email { get; set; }
        public decimal? MontoMaximo { get; set; }
        public string? TipoInscripcion { get; set; }
        public string? CodigoTercero { get; set; }
        public string TipoMatricula { get; set; } = null!;
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerbancohsbccolombiaProv { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual Tercero CodTerceroNavigation { get; set; } = null!;
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual Banco IdBancoNavigation { get; set; } = null!;
    }
}
