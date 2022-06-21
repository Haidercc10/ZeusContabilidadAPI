using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableMaestro
    {
        public decimal IdenMaestro { get; set; }
        public decimal IdenVariable { get; set; }
        public string? Formula { get; set; }
        public int? OrdenEvaluacion { get; set; }
        public bool? VerEnAyuda { get; set; }
        public int IdenVariablemaestro { get; set; }
        public bool? HefestoIsRequired { get; set; }
        public bool? HefestoUniqueValue { get; set; }
        public bool? HefestoCompoundValue { get; set; }
        public string? HefestoDefaultFormulaFormat { get; set; }

        public virtual VariableDefinicionMaestro IdenMaestroNavigation { get; set; } = null!;
        public virtual VariableDefinicion IdenVariableNavigation { get; set; } = null!;
    }
}
