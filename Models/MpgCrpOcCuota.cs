using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgCrpOcCuota
    {
        public decimal Iden { get; set; }
        public decimal IdenRelacionado { get; set; }
        public string Anomes { get; set; } = null!;
        public decimal Valor { get; set; }
    }
}
