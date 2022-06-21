using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Seccione
    {
        public Seccione()
        {
            Revelaciones = new HashSet<Revelacione>();
            RevelacionesAuditoria = new HashSet<RevelacionesAuditorium>();
            RevelacionesPeriodos = new HashSet<RevelacionesPeriodo>();
        }

        public int Iden { get; set; }
        public string Tipo { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string CodigoPadre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Deshabilitado { get; set; }
        public string? Orden { get; set; }

        public virtual ICollection<Revelacione> Revelaciones { get; set; }
        public virtual ICollection<RevelacionesAuditorium> RevelacionesAuditoria { get; set; }
        public virtual ICollection<RevelacionesPeriodo> RevelacionesPeriodos { get; set; }
    }
}
