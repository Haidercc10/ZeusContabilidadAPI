using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CtasEspecificasAsobancarium
    {
        public string Cuenta { get; set; } = null!;
        public int IdenCtasespecificasasobancaria { get; set; }

        public virtual Maecont CuentaNavigation { get; set; } = null!;
    }
}
