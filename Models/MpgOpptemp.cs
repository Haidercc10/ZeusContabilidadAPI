using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgOpptemp
    {
        public int IdenDoc { get; set; }
        public string Tipo { get; set; } = null!;
        public int Iden { get; set; }
        public int? IdenRelacionado { get; set; }
        public decimal Valor { get; set; }
        public int IdenMpgOpptemp { get; set; }
    }
}
