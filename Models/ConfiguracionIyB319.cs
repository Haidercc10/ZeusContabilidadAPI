using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ConfiguracionIyB319
    {
        public decimal Iden { get; set; }
        public decimal Columna { get; set; }
        public string Cuenta { get; set; } = null!;
    }
}
