using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfPagareBody
    {
        public int Iden { get; set; }
        public int IdenHead { get; set; }
        public int Numero { get; set; }
        public string Leyenda { get; set; } = null!;
    }
}
