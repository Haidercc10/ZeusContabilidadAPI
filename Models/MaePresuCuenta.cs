using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaePresuCuenta
    {
        public string CodPresu { get; set; } = null!;
        public string CodPuc { get; set; } = null!;
        public string CodCco { get; set; } = null!;
        public int IdenMaepresuCuentas { get; set; }
    }
}
