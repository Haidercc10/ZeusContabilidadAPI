using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AdministrarFuentesPreContabilizacion
    {
        public decimal Iden { get; set; }
        public int IdenPersonalAutorizacion { get; set; }
        public string Fuente { get; set; } = null!;
    }
}
