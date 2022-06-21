using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Relacione
    {
        public string? Torigen { get; set; }
        public string? Idtorigen { get; set; }
        public string? Columnaori { get; set; }
        public string? Idcolumnaori { get; set; }
        public string? Tdestino { get; set; }
        public string? Idtdestino { get; set; }
        public string? Columnadest { get; set; }
        public string? Idcolumnadest { get; set; }
        public int IdenRelaciones { get; set; }
    }
}
