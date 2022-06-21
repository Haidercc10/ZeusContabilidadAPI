using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DiasxBu
    {
        public string Fecha { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string Permitir { get; set; } = null!;
        public int IdenDiasxbu { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Dia FechaNavigation { get; set; } = null!;
    }
}
