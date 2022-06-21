using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfPagarePrestamoBody
    {
        public int Iden { get; set; }
        public int IdenPagarePrestamohead { get; set; }
        public int Numero { get; set; }
        public string Leyenda { get; set; } = null!;
    }
}
