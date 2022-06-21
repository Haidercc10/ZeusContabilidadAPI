using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Numconsadc
    {
        public decimal Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Consecutivo { get; set; }
        public int IdenNumconsadc { get; set; }
    }
}
