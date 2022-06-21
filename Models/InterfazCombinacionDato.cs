using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class InterfazCombinacionDato
    {
        public decimal Iden { get; set; }
        public decimal? InterfazCombinacionIden { get; set; }
        public decimal? InterfazVariablesIden { get; set; }
        public string? Valor { get; set; }

        public virtual InterfazCombinacion? InterfazCombinacionIdenNavigation { get; set; }
        public virtual InterfazVariable? InterfazVariablesIdenNavigation { get; set; }
    }
}
