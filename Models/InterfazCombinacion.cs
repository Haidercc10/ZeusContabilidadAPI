using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class InterfazCombinacion
    {
        public InterfazCombinacion()
        {
            InterfazCombinacionDatos = new HashSet<InterfazCombinacionDato>();
        }

        public decimal Iden { get; set; }
        public decimal? InterfazProceso { get; set; }
        public decimal? Criterio0 { get; set; }
        public decimal? Criterio1 { get; set; }
        public decimal? Criterio2 { get; set; }
        public decimal? Criterio3 { get; set; }
        public decimal? Criterio4 { get; set; }
        public decimal? Criterio5 { get; set; }
        public decimal? Criterio6 { get; set; }
        public decimal? Criterio7 { get; set; }
        public decimal? Criterio8 { get; set; }
        public decimal? Criterio9 { get; set; }

        public virtual InterfazProceso? InterfazProcesoNavigation { get; set; }
        public virtual ICollection<InterfazCombinacionDato> InterfazCombinacionDatos { get; set; }
    }
}
