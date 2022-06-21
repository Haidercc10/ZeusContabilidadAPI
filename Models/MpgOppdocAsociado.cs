using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgOppdocAsociado
    {
        public MpgOppdocAsociado()
        {
            MpgOppcuota = new HashSet<MpgOppcuota>();
            MpgOppentrada = new HashSet<MpgOppentrada>();
        }

        public int Iden { get; set; }
        public int IdenOpp { get; set; }
        public int? IdenCrpcxp { get; set; }

        public virtual MpgDocumento? IdenCrpcxpNavigation { get; set; }
        public virtual MpgDocumento IdenOppNavigation { get; set; } = null!;
        public virtual ICollection<MpgOppcuota> MpgOppcuota { get; set; }
        public virtual ICollection<MpgOppentrada> MpgOppentrada { get; set; }
    }
}
