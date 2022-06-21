using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgOppentrada
    {
        public MpgOppentrada()
        {
            MpgOpprubros = new HashSet<MpgOpprubro>();
        }

        public int Iden { get; set; }
        public int IdenDocAsociado { get; set; }
        public int IdenEntrada { get; set; }
        public decimal Valor { get; set; }
        public decimal Satisfecho { get; set; }
        public decimal Disminuciones { get; set; }
        public decimal Saldo { get; set; }
        public decimal VrRetenciones { get; set; }
        public decimal VrRetencionesDis { get; set; }

        public virtual MpgOppdocAsociado IdenDocAsociadoNavigation { get; set; } = null!;
        public virtual MpgDocumento IdenEntradaNavigation { get; set; } = null!;
        public virtual ICollection<MpgOpprubro> MpgOpprubros { get; set; }
    }
}
