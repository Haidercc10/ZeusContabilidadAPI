using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfCxC
    {
        public string Cuenta { get; set; } = null!;
        public int IndEstudio { get; set; }
        public int IndSeguro { get; set; }
        public int IndCapacitacion { get; set; }
        public int IndComision { get; set; }
        public int IdenMfCxc { get; set; }

        public virtual Maecont CuentaNavigation { get; set; } = null!;
    }
}
