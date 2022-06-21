using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgCrpOc
    {
        public decimal Iden { get; set; }
        public decimal IdenCrp { get; set; }
        public decimal IdenOc { get; set; }
        public string TipoDocumento { get; set; } = null!;
    }
}
