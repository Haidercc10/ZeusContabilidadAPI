using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Revelacione
    {
        public int Iden { get; set; }
        public int Consecutra { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime FechaGrabacion { get; set; }
        public int? ConsecutraRelacioando { get; set; }
        public int? IdenSecciones { get; set; }

        public virtual Seccione? IdenSeccionesNavigation { get; set; }
    }
}
