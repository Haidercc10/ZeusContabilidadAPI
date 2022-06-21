using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgCuota
    {
        public MpgCuota()
        {
            MpgOppcuota = new HashSet<MpgOppcuota>();
        }

        public int Iden { get; set; }
        public int IdenRelacionado { get; set; }
        public string Vencimiento { get; set; } = null!;
        public decimal VrCuota { get; set; }
        public decimal Satisfecho { get; set; }
        public decimal Adiciones { get; set; }
        public decimal Disminuciones { get; set; }
        public decimal Saldo { get; set; }
        public string TipoRegistro { get; set; } = null!;
        public int CreadoAdicion { get; set; }

        public virtual MpgDocumento IdenRelacionadoNavigation { get; set; } = null!;
        public virtual ICollection<MpgOppcuota> MpgOppcuota { get; set; }
    }
}
