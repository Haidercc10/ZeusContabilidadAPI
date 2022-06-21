using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactConcFormulaSql
    {
        public decimal Iden { get; set; }
        public string? ConcFco { get; set; }
        public string? FormulaValorSql { get; set; }
        public string? FormulaCantidadSql { get; set; }

        public virtual Factconc? ConcFcoNavigation { get; set; }
    }
}
