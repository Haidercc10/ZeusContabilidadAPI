using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Familia
    {
        public string Servidor { get; set; } = null!;
        public string Base { get; set; } = null!;
        public string? Tipo { get; set; }
        public int IdenFamilias { get; set; }
    }
}
