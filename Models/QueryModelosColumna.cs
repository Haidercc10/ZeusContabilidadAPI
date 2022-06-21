using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryModelosColumna
    {
        public int Iden { get; set; }
        public string QuerySecuencia { get; set; } = null!;
        public string NombreColumna { get; set; } = null!;
    }
}
