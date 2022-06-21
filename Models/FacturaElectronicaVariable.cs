using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaVariable
    {
        public FacturaElectronicaVariable()
        {
            FacturaElectronicaFacturadoresAsignacionVariables = new HashSet<FacturaElectronicaFacturadoresAsignacionVariable>();
            FacturaElectronicaFacturadoresEquivalencia = new HashSet<FacturaElectronicaFacturadoresEquivalencium>();
        }

        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Titulo { get; set; }
        public string? ListaPosibilidades { get; set; }
        public bool? SiAyuda { get; set; }
        public string? SeccionAyuda { get; set; }
        public bool? SiMaestroGenerico { get; set; }
        public bool? SiAyudaMaestroGenerico { get; set; }
        public string? SeccionAyudaMaestroGenerico { get; set; }
        public string? Descripcion { get; set; }
        public int? Orden { get; set; }
        public int IdenFacturaelectronicaVariables { get; set; }
        public string? CodigoBuscador { get; set; }
        public string? ColumnaDescripcionMaestro { get; set; }
        public string? OpcionesSelecionables { get; set; }

        public virtual ICollection<FacturaElectronicaFacturadoresAsignacionVariable> FacturaElectronicaFacturadoresAsignacionVariables { get; set; }
        public virtual ICollection<FacturaElectronicaFacturadoresEquivalencium> FacturaElectronicaFacturadoresEquivalencia { get; set; }
    }
}
