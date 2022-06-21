using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RevelacionesAuditorium
    {
        public int Iden { get; set; }
        public string Periodo { get; set; } = null!;
        public int IdenSecciones { get; set; }
        public int NoRevelar { get; set; }
        public string? Usuario { get; set; }
        public DateTime FechaGrabacion { get; set; }

        public virtual Seccione IdenSeccionesNavigation { get; set; } = null!;
    }
}
