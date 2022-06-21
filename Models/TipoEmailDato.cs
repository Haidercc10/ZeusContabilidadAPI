using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoEmailDato
    {
        public decimal Iden { get; set; }
        public decimal IdenTipoEmail { get; set; }
        public string CodigoMaestro { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual TipoEmail IdenTipoEmailNavigation { get; set; } = null!;
    }
}
