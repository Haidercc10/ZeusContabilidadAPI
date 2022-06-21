using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerScotiabankPeruProv
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string FormaPago { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Oficina { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public string Cci { get; set; } = null!;
        public int Moneda { get; set; }
        public bool Habilitado { get; set; }
        public int IdenGerscotiabankperuProv { get; set; }
        public string? IdBanco { get; set; }
        public string Email { get; set; } = null!;

        public virtual Banco? IdBancoNavigation { get; set; }
    }
}
