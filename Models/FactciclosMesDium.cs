using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactciclosMesDium
    {
        public string Ciclo { get; set; } = null!;
        public int Mes { get; set; }
        public int Dia { get; set; }
        public int IdenFactciclosmesdia { get; set; }

        public virtual Factciclo CicloNavigation { get; set; } = null!;
    }
}
