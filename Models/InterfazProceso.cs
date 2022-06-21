using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class InterfazProceso
    {
        public InterfazProceso()
        {
            InterfazAsignaVariables = new HashSet<InterfazAsignaVariable>();
            InterfazCombinacions = new HashSet<InterfazCombinacion>();
        }

        public decimal Iden { get; set; }
        public decimal InterfazIden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool? Criterio0 { get; set; }
        public bool? Criterio1 { get; set; }
        public bool? Criterio2 { get; set; }
        public bool? Criterio3 { get; set; }
        public bool? Criterio4 { get; set; }
        public bool? Criterio5 { get; set; }
        public bool? Criterio6 { get; set; }
        public bool? Criterio7 { get; set; }
        public bool? Criterio8 { get; set; }
        public bool? Criterio9 { get; set; }

        public virtual Interfaz InterfazIdenNavigation { get; set; } = null!;
        public virtual ICollection<InterfazAsignaVariable> InterfazAsignaVariables { get; set; }
        public virtual ICollection<InterfazCombinacion> InterfazCombinacions { get; set; }
    }
}
