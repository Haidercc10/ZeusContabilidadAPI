using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppMovExterno
    {
        public int Iden { get; set; }
        public string CodigoApp { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
    }
}
