using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoFacturaRestriccione
    {
        public decimal Iden { get; set; }
        public string CodigoTipoFactura { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public string Maestro { get; set; } = null!;
        public string CodigoMaestro { get; set; } = null!;

        public virtual Tipofact CodigoTipoFacturaNavigation { get; set; } = null!;
    }
}
