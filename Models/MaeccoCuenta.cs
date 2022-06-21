using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeccoCuenta
    {
        public string CentroCosto { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public int IdenMaeccoCuentas { get; set; }

        public virtual Maecco CentroCostoNavigation { get; set; } = null!;
        public virtual Maecont CuentaNavigation { get; set; } = null!;
    }
}
