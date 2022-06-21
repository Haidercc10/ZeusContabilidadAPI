using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaFacturadoresEquivalencium
    {
        public string Facturador { get; set; } = null!;
        public string TipoMaestro { get; set; } = null!;
        public string Variable { get; set; } = null!;
        public string CodigoMaestro { get; set; } = null!;
        public string? Valor { get; set; }
        public int IdenFacturaelectronicaFacturadoresEquivalencia { get; set; }

        public virtual FacturaElectronicaFacturadore FacturadorNavigation { get; set; } = null!;
        public virtual FacturaElectronicaVariable VariableNavigation { get; set; } = null!;
    }
}
