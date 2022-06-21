using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TransacBr
    {
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public int Consecutra { get; set; }
        public string Bu { get; set; } = null!;
        public bool Parcial { get; set; }
        public int IdenTransacBr { get; set; }
    }
}
