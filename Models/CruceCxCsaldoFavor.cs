using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CruceCxCsaldoFavor
    {
        public string Cuenta { get; set; } = null!;
        public int Seleccionada { get; set; }
        public int IdenCrucecxcsaldofavor { get; set; }

        public virtual Maecont CuentaNavigation { get; set; } = null!;
    }
}
