using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaFacturadoresAsignacionVariable
    {
        public string Facturador { get; set; } = null!;
        public string TipoMaestro { get; set; } = null!;
        public string Variable { get; set; } = null!;
        public int IdenFacturaelectronicaFacturadoresAsignacionvariables { get; set; }
        public int? Orden { get; set; }

        public virtual FacturaElectronicaFacturadore FacturadorNavigation { get; set; } = null!;
        public virtual FacturaElectronicaVariable VariableNavigation { get; set; } = null!;
    }
}
