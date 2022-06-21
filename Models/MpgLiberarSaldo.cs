using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgLiberarSaldo
    {
        public MpgLiberarSaldo()
        {
            MpgLiberarSaldosDets = new HashSet<MpgLiberarSaldosDet>();
        }

        public decimal Iden { get; set; }
        public string Fuente { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Vigencia { get; set; } = null!;
        public string TipoDocAutorizacion { get; set; } = null!;
        public string DocAutorizacion { get; set; } = null!;
        public string FechaAutorizacion { get; set; } = null!;
        public string DocumentoI { get; set; } = null!;
        public string DocumentoF { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Bu { get; set; } = null!;

        public virtual Fuente FuenteNavigation { get; set; } = null!;
        public virtual MpgTipoDocAutorizacion TipoDocAutorizacionNavigation { get; set; } = null!;
        public virtual ICollection<MpgLiberarSaldosDet> MpgLiberarSaldosDets { get; set; }
    }
}
