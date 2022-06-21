using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Regional
    {
        public string Idbanco { get; set; } = null!;
        public string Regional1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdenRegional { get; set; }
    }
}
