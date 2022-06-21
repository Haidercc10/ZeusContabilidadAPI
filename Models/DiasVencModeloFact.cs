using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DiasVencModeloFact
    {
        public string? IdModelo { get; set; }
        public string? Fecha { get; set; }
        public int IdenDiasvencmodelofact { get; set; }

        public virtual Factmodeloh? IdModeloNavigation { get; set; }
    }
}
