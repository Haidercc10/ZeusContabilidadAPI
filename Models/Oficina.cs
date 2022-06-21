using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Oficina
    {
        public string Idbanco { get; set; } = null!;
        public string Regional { get; set; } = null!;
        public string Oficina1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdenOficina { get; set; }
    }
}
