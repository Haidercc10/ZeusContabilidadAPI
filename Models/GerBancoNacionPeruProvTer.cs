using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoNacionPeruProvTer
    {
        public long Iden { get; set; }
        public string TipoMatricula { get; set; } = null!;
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public string? CodTercero { get; set; }
        public string? CodProveedor { get; set; }
        public string? CodigoTercero { get; set; }
        public string Cuenta { get; set; } = null!;
        public string Cci { get; set; } = null!;
        public int Moneda { get; set; }
        public bool Habilitado { get; set; }
        public string? IdBanco { get; set; }

        public virtual Banco? IdBancoNavigation { get; set; }
    }
}
