using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBogotaProv
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string EnviarInfo { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string CodBanco { get; set; } = null!;
        public string CodBancoGer { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string Mostrar { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerbogotaProv { get; set; }
        public string CodigoOficina { get; set; } = null!;

        public virtual Banco CodBancoNavigation { get; set; } = null!;
        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual Tercero CodTerceroNavigation { get; set; } = null!;
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
    }
}
