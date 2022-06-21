using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpExtractosDefinicionCuenta
    {
        public decimal Iden { get; set; }
        public decimal IdenExtractoDefinicion { get; set; }
        public string Cuenta { get; set; } = null!;

        public virtual Maecont CuentaNavigation { get; set; } = null!;
        public virtual ImpExtractosDefinicion IdenExtractoDefinicionNavigation { get; set; } = null!;
    }
}
