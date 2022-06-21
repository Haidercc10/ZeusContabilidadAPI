using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RevelacionesPeriodosAnexo
    {
        public int Iden { get; set; }
        public int IdenRevelacionesPeriodos { get; set; }
        public string Nombre { get; set; } = null!;
        public string Plantilla { get; set; } = null!;
        public int IdAplicacionesOrigen { get; set; }
        public int IdAplicacionesFunciones { get; set; }

        public virtual RevelacionesPeriodo IdenRevelacionesPeriodosNavigation { get; set; } = null!;
    }
}
