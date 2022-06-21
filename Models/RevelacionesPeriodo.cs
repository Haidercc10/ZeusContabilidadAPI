using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RevelacionesPeriodo
    {
        public RevelacionesPeriodo()
        {
            RevelacionesPeriodosAnexos = new HashSet<RevelacionesPeriodosAnexo>();
        }

        public int Iden { get; set; }
        public string Periodo { get; set; } = null!;
        public int IdenSecciones { get; set; }
        public string CodigoNota { get; set; } = null!;
        public string NombreNota { get; set; } = null!;
        public string? Revelacion { get; set; }
        public string? Usuario { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public int TrasladarSiguientePeriodo { get; set; }

        public virtual Seccione IdenSeccionesNavigation { get; set; } = null!;
        public virtual ICollection<RevelacionesPeriodosAnexo> RevelacionesPeriodosAnexos { get; set; }
    }
}
