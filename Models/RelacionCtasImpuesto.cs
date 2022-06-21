using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RelacionCtasImpuesto
    {
        public int Id { get; set; }
        public string CuentaPrincipal { get; set; } = null!;
        public string CuentaBase { get; set; } = null!;

        public virtual Maecont CuentaBaseNavigation { get; set; } = null!;
        public virtual Maecont CuentaPrincipalNavigation { get; set; } = null!;
    }
}
