using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgLiberarSaldosDet
    {
        public decimal Iden { get; set; }
        public decimal IdenRelacionado { get; set; }
        public int IdenMpgdocumento { get; set; }

        public virtual MpgDocumento IdenMpgdocumentoNavigation { get; set; } = null!;
        public virtual MpgLiberarSaldo IdenRelacionadoNavigation { get; set; } = null!;
    }
}
