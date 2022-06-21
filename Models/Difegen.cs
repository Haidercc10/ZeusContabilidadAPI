using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Difegen
    {
        public string Iddif { get; set; } = null!;
        public string Fechaplic { get; set; } = null!;
        public decimal Vrmesdif { get; set; }
        public string Idfuente { get; set; } = null!;
        public string? Numdoctra { get; set; }
        public int IdenDifegen { get; set; }
        public string Statustra { get; set; } = null!;
    }
}
