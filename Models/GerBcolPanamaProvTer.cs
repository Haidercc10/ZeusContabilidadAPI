using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBcolPanamaProvTer
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public string Banco { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string BancoInterm { get; set; } = null!;
        public string GastoInterBanc { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public int IdenGerBcolpanamaProvter { get; set; }

        public virtual GerBcolPanamaEntidade BancoNavigation { get; set; } = null!;
        public virtual Tercero CodTerceroNavigation { get; set; } = null!;
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
    }
}
