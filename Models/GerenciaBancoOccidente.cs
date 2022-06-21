using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerenciaBancoOccidente
    {
        public string? Idprove { get; set; }
        public string? Idtercero { get; set; }
        public string? Idbanco { get; set; }
        public string? Cuenta { get; set; }
        public string? Formapago { get; set; }
        public string? Tipocuenta { get; set; }
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerenciaBancoOccidente { get; set; }

        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual Proveedore? IdproveNavigation { get; set; }
    }
}
