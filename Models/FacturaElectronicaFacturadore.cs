using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaFacturadore
    {
        public FacturaElectronicaFacturadore()
        {
            FacturaElectronicaFacturadoresAsignacionVariables = new HashSet<FacturaElectronicaFacturadoresAsignacionVariable>();
            FacturaElectronicaFacturadoresEquivalencia = new HashSet<FacturaElectronicaFacturadoresEquivalencium>();
        }

        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdenFacturaelectronicaFacturadores { get; set; }
        public int? UseConectU { get; set; }

        public virtual ICollection<FacturaElectronicaFacturadoresAsignacionVariable> FacturaElectronicaFacturadoresAsignacionVariables { get; set; }
        public virtual ICollection<FacturaElectronicaFacturadoresEquivalencium> FacturaElectronicaFacturadoresEquivalencia { get; set; }
    }
}
