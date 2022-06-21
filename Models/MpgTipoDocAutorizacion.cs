using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgTipoDocAutorizacion
    {
        public MpgTipoDocAutorizacion()
        {
            MpgDocumentos = new HashSet<MpgDocumento>();
            MpgLiberarSaldos = new HashSet<MpgLiberarSaldo>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdenMpgTipodocautorizacion { get; set; }

        public virtual ICollection<MpgDocumento> MpgDocumentos { get; set; }
        public virtual ICollection<MpgLiberarSaldo> MpgLiberarSaldos { get; set; }
    }
}
