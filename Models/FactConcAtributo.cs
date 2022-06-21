using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactConcAtributo
    {
        public int Iden { get; set; }
        public string? ConcFco { get; set; }
        public bool? ExcluirEnAnticipoFactAutomatica { get; set; }

        public virtual Factconc? ConcFcoNavigation { get; set; }
    }
}
