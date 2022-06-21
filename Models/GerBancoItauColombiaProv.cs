using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoItauColombiaProv
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public string IdBanco { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
        public string Email { get; set; } = null!;
        public decimal? MontoMaximo { get; set; }
        public string TipoInscripcion { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string? CodigoMatricula { get; set; }
        public int Principal { get; set; }
        public int IdenGerBancoItauColombiaProv { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
    }
}
