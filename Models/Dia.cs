using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Dia
    {
        public Dia()
        {
            DiasxBus = new HashSet<DiasxBu>();
        }

        public string Fecha { get; set; } = null!;
        public string OpenMes { get; set; } = null!;
        public int IdenDias { get; set; }

        public virtual ICollection<DiasxBu> DiasxBus { get; set; }
    }
}
