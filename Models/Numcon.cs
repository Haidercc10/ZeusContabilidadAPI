using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Numcon
    {
        public string Ano { get; set; } = null!;
        public string Idfuente { get; set; } = null!;
        public string Inicio { get; set; } = null!;
        public long Numconse { get; set; }
        public int IdenNumcons { get; set; }

        public virtual Fuente IdfuenteNavigation { get; set; } = null!;
    }
}
