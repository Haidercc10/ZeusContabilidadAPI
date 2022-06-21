using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SecuencialPagoGerencium
    {
        public decimal Iden { get; set; }
        public string AlfaNumerico { get; set; } = null!;
        public decimal Numerico { get; set; }
    }
}
