using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppProgramacionesLog
    {
        public decimal IdenProgramacion { get; set; }
        public decimal IdenEstadoAnterior { get; set; }
        public decimal IdenEstadoNuevo { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public string Usuario { get; set; } = null!;
        public int IdenContPppProgramacionesLog { get; set; }

        public virtual ContPppProgramacione IdenProgramacionNavigation { get; set; } = null!;
    }
}
